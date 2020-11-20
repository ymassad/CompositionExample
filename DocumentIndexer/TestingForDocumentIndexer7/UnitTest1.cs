using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.IO.Abstractions.TestingHelpers;
using DocumentIndexer;
using DocumentIndexer.Data;
using DocumentIndexer.Interfaces;

namespace TestingForDocumentIndexer7
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var createSut = Program.CreateApplication();

            createSut.Invoke("C:\\Documents", new MockFileSystem(), new FakeDataContextFactory(),
                "https://fakeservice.com", new FakeRestClient(), "C:\\Output");
        }
    }

    public class FakeRestClient : IRestClient
    {
        public string Post(string url, string body)
        {
            throw new NotImplementedException();
        }
    }

    public class FakeDataContextFactory : IDataContextFactory
    {
        public DataContext Create()
        {
            throw new NotImplementedException();
        }
    }


}
