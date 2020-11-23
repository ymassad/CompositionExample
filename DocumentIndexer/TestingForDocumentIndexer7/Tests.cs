using System;
using System.IO.Abstractions.TestingHelpers;
using System.Linq;
using System.Xml.Linq;
using System.Xml.XPath;
using DocumentIndexer;
using DocumentIndexer.Data;
using DocumentIndexer.Interfaces;
using Effort;
using FakeItEasy;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace TestingForDocumentIndexer7
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void Test()
        {
            //Arrange
            var createSut = Program.CreateApplication();

            using (var effortConnection = DbConnectionFactory.CreateTransient())
            {
                var mockFileSystem = new MockFileSystem();

                mockFileSystem.Directory.CreateDirectory("C:\\Documents");
                mockFileSystem.Directory.CreateDirectory("C:\\Output");
                
                mockFileSystem.File.WriteAllText("C:\\Documents\\document1.txt", "car house");

                var restClient = A.Fake<IRestClient>();

                A.CallTo(() => restClient.Post(new Uri("https://fakeservice.com/GetWords"), A<string>.Ignored))
                    .ReturnsLazily((Uri url, string body) =>
                    {
                        var fakeWords = body
                            .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                            .Distinct()
                            .Select(x => x + "_fake")
                            .ToArray();

                        return JsonConvert.SerializeObject(fakeWords);
                    });

                var fakeDataContextFactory = new FakeDataContextFactory(effortConnection);

                var runnable = createSut.Invoke(
                    documentsSourcePath: "C:\\Documents",
                    fileSystem: mockFileSystem,
                    dataContextFactory: fakeDataContextFactory,
                    extractorServiceUrl: new Uri("https://fakeservice.com"),
                    restClient: restClient,
                    outputFolderPath: "C:\\Output");
                
                //Act
                runnable.Run();
                
                //Assert
                
                //Assert results from processor 1 (that uses simple words extractor and stores to the database)

                using (var databaseContext = fakeDataContextFactory.Create())
                {
                    databaseContext.Documents
                        .Select(x => x.Name)
                        .Should()
                        .BeEquivalentTo("document1.txt");

                    databaseContext.Documents
                        .Select(x => x.Content)
                        .Should()
                        .BeEquivalentTo("car house");
                }

                //Assert results from processor 2 (that uses rest based words extractor and stores to the filesystem)

                var serializedDocument1 = XDocument.Parse(mockFileSystem.File.ReadAllText("C:\\Output\\document1.txt"));

                var inputDocumentElement =
                    serializedDocument1
                        .Element("InputDocumentWithExtractedWords")
                    .Element("InputDocument");

                inputDocumentElement
                    .Element("DocumentName")
                    .Value.Should().Be("document1.txt");

                inputDocumentElement
                    .Element("DocumentContent")
                    .Value.Should().Be("car house");

                serializedDocument1
                    .Element("InputDocumentWithExtractedWords")
                    .Element("ExtractedWords")
                    .Elements("string")
                    .Select(x => x.Value)
                    .Should()
                    .BeEquivalentTo("car_fake", "house_fake");
            }
        }
    }
}