using System;
using DIVEX.Core;

namespace DocumentIndexer
{
    
    public static class JoinAllInputsExtensionMethods1
    {
    
        public static DocumentIndexer.JoinAllInputsExtensionMethods1.JoinAllInputsClass JoinAllInputs(this global::DocumentIndexer.ReplaceLastExtensionMethods1.ReplaceLastClass function)
        {
            return new JoinAllInputsClass(function);
        }
        [DIVEX.Core.JoinAllInputsClassAttribute("function")]
        public sealed class JoinAllInputsClass
        {
        
            public readonly global::DocumentIndexer.ReplaceLastExtensionMethods1.ReplaceLastClass function;
            public JoinAllInputsClass(global::DocumentIndexer.ReplaceLastExtensionMethods1.ReplaceLastClass function)
            {
                this.function = function;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0)]
            [DIVEX.Core.JoinedParametersDetailsAttribute("(0;3),(1;4;8),2,5,6,7")]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            public global::DocumentIndexer.Implementations.CompositeRunnable Invoke(global::System.String documentsSourcePath, global::DocumentIndexer.Interfaces.IFileSystem fileSystem, global::DocumentIndexer.Interfaces.IDataContextFactory dataContextFactory, global::System.String extractorServiceUrl, global::DocumentIndexer.Interfaces.IRestClient restClient, global::System.String outputFolderPath)
            {
                return this.function.Invoke(documentsSourcePath,fileSystem,dataContextFactory,documentsSourcePath,fileSystem,extractorServiceUrl,restClient,outputFolderPath,fileSystem);
            }
        
        }
    
    }
}

namespace DocumentIndexer
{
    
    public static class ReplaceWithNamedArgumentsExtensionMethods1
    {
    
        public static DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods1.ReplaceClass Replace(this DIVEX.Core.ConstructorOf<global::DocumentIndexer.Implementations.DocumentGrabberAndProcessor> f1, global::DocumentIndexer.RenameExtensionMethods2.RenameClass documentsSource)
        {
            return new ReplaceClass(f1, documentsSource);
        }
        [DIVEX.Core.ReplaceClassAttribute("f1", "f2", "documentsSource")]
        public sealed class ReplaceClass
        {
        
            public readonly AdapterForF1 f1;
            public readonly global::DocumentIndexer.RenameExtensionMethods2.RenameClass f2;
            public ReplaceClass(AdapterForF1 f1, global::DocumentIndexer.RenameExtensionMethods2.RenameClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.ParameterIndexAttribute(0)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public global::DocumentIndexer.Implementations.DocumentGrabberAndProcessor Invoke(global::System.String documentsSourcePath, global::DocumentIndexer.Interfaces.IFileSystem fileSystem, global::DocumentIndexer.Interfaces.IDocumentProcessor documentProcessor)
            {
                return this.f1.Invoke(this.f2.Invoke(documentsSourcePath, fileSystem), documentProcessor);
            }
        
        }
        [DIVEX.Core.CtorOfClassAttribute(typeof(global::DocumentIndexer.Implementations.DocumentGrabberAndProcessor))]
        public sealed class AdapterForF1
        {
        
            public static implicit operator DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods1.AdapterForF1(DIVEX.Core.ConstructorOf<global::DocumentIndexer.Implementations.DocumentGrabberAndProcessor> c)
            {
                return new AdapterForF1();
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.OriginalConstructorAttribute("DocumentIndexer.Interfaces.IDocumentsSource", "DocumentIndexer.Interfaces.IDocumentProcessor")]
            public global::DocumentIndexer.Implementations.DocumentGrabberAndProcessor Invoke(global::DocumentIndexer.Interfaces.IDocumentsSource documentsSource, global::DocumentIndexer.Interfaces.IDocumentProcessor documentProcessor)
            {
                return new global::DocumentIndexer.Implementations.DocumentGrabberAndProcessor(documentsSource, documentProcessor);
            }
        
        }
    
    }
}

namespace DocumentIndexer
{
    
    public static class ReplaceWithNamedArgumentsExtensionMethods2
    {
    
        public static DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods2.ReplaceClass Replace(this global::DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods1.ReplaceClass f1, DIVEX.Core.ConstructorOf<global::DocumentIndexer.Implementations.IndexProcessor> documentProcessor)
        {
            return new ReplaceClass(f1, documentProcessor);
        }
        [DIVEX.Core.ReplaceClassAttribute("f1", "f2", "documentProcessor")]
        public sealed class ReplaceClass
        {
        
            public readonly global::DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods1.ReplaceClass f1;
            public readonly AdapterForF2 f2;
            public ReplaceClass(global::DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods1.ReplaceClass f1, AdapterForF2 f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.ParameterIndexAttribute(2)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public global::DocumentIndexer.Implementations.DocumentGrabberAndProcessor Invoke(global::System.String documentsSourcePath, global::DocumentIndexer.Interfaces.IFileSystem fileSystem, global::DocumentIndexer.Interfaces.IWordsExtractor wordsExtractor, global::DocumentIndexer.Interfaces.IDocumentWithExtractedWordsStore documentWithExtractedWordsStore)
            {
                return this.f1.Invoke(documentsSourcePath, fileSystem, this.f2.Invoke(wordsExtractor, documentWithExtractedWordsStore));
            }
        
        }
        [DIVEX.Core.CtorOfClassAttribute(typeof(global::DocumentIndexer.Implementations.IndexProcessor))]
        public sealed class AdapterForF2
        {
        
            public static implicit operator DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods2.AdapterForF2(DIVEX.Core.ConstructorOf<global::DocumentIndexer.Implementations.IndexProcessor> c)
            {
                return new AdapterForF2();
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.OriginalConstructorAttribute("DocumentIndexer.Interfaces.IWordsExtractor", "DocumentIndexer.Interfaces.IDocumentWithExtractedWordsStore")]
            public global::DocumentIndexer.Implementations.IndexProcessor Invoke(global::DocumentIndexer.Interfaces.IWordsExtractor wordsExtractor, global::DocumentIndexer.Interfaces.IDocumentWithExtractedWordsStore documentWithExtractedWordsStore)
            {
                return new global::DocumentIndexer.Implementations.IndexProcessor(wordsExtractor, documentWithExtractedWordsStore);
            }
        
        }
    
    }
}

namespace DocumentIndexer
{
    
    public static class ReplaceWithNamedArgumentsExtensionMethods3
    {
    
        public static DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods3.ReplaceClass Replace(this global::DocumentIndexer.Program.VarReturn.VR1 f1, DIVEX.Core.ConstructorOf<global::DocumentIndexer.Implementations.SimpleWordsExtractor> wordsExtractor)
        {
            return new ReplaceClass(f1, wordsExtractor);
        }
        [DIVEX.Core.ReplaceClassAttribute("f1", "f2", "wordsExtractor")]
        public sealed class ReplaceClass
        {
        
            public readonly global::DocumentIndexer.Program.VarReturn.VR1 f1;
            public readonly AdapterForF2 f2;
            public ReplaceClass(global::DocumentIndexer.Program.VarReturn.VR1 f1, AdapterForF2 f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.ParameterIndexAttribute(2)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public global::DocumentIndexer.Implementations.DocumentGrabberAndProcessor Invoke(global::System.String documentsSourcePath, global::DocumentIndexer.Interfaces.IFileSystem fileSystem, global::DocumentIndexer.Interfaces.IDocumentWithExtractedWordsStore documentWithExtractedWordsStore)
            {
                return this.f1.Invoke(documentsSourcePath, fileSystem, this.f2.Invoke(), documentWithExtractedWordsStore);
            }
        
        }
        [DIVEX.Core.CtorOfClassAttribute(typeof(global::DocumentIndexer.Implementations.SimpleWordsExtractor))]
        public sealed class AdapterForF2
        {
        
            public static implicit operator DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods3.AdapterForF2(DIVEX.Core.ConstructorOf<global::DocumentIndexer.Implementations.SimpleWordsExtractor> c)
            {
                return new AdapterForF2();
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.OriginalConstructorAttribute()]
            public global::DocumentIndexer.Implementations.SimpleWordsExtractor Invoke()
            {
                return new global::DocumentIndexer.Implementations.SimpleWordsExtractor();
            }
        
        }
    
    }
}

namespace DocumentIndexer
{
    
    public static class ReplaceWithNamedArgumentsExtensionMethods4
    {
    
        public static DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods4.ReplaceClass Replace(this global::DocumentIndexer.Program.VarReturn.VR1 f1, global::DocumentIndexer.RenameExtensionMethods1.RenameClass wordsExtractor)
        {
            return new ReplaceClass(f1, wordsExtractor);
        }
        [DIVEX.Core.ReplaceClassAttribute("f1", "f2", "wordsExtractor")]
        public sealed class ReplaceClass
        {
        
            public readonly global::DocumentIndexer.Program.VarReturn.VR1 f1;
            public readonly global::DocumentIndexer.RenameExtensionMethods1.RenameClass f2;
            public ReplaceClass(global::DocumentIndexer.Program.VarReturn.VR1 f1, global::DocumentIndexer.RenameExtensionMethods1.RenameClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.ParameterIndexAttribute(2)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public global::DocumentIndexer.Implementations.DocumentGrabberAndProcessor Invoke(global::System.String documentsSourcePath, global::DocumentIndexer.Interfaces.IFileSystem fileSystem, global::System.String extractorServiceUrl, global::DocumentIndexer.Interfaces.IRestClient restClient, global::DocumentIndexer.Interfaces.IDocumentWithExtractedWordsStore documentWithExtractedWordsStore)
            {
                return this.f1.Invoke(documentsSourcePath, fileSystem, this.f2.Invoke(extractorServiceUrl, restClient), documentWithExtractedWordsStore);
            }
        
        }
    
    }
}

namespace DocumentIndexer
{
    
    public static class ReplaceWithNamedArgumentsExtensionMethods5
    {
    
        public static DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods5.ReplaceClass Replace(this global::DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods3.ReplaceClass f1, DIVEX.Core.ConstructorOf<global::DocumentIndexer.Implementations.DocumentWithExtractedWordsStore> documentWithExtractedWordsStore)
        {
            return new ReplaceClass(f1, documentWithExtractedWordsStore);
        }
        [DIVEX.Core.ReplaceClassAttribute("f1", "f2", "documentWithExtractedWordsStore")]
        public sealed class ReplaceClass
        {
        
            public readonly global::DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods3.ReplaceClass f1;
            public readonly AdapterForF2 f2;
            public ReplaceClass(global::DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods3.ReplaceClass f1, AdapterForF2 f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.ParameterIndexAttribute(2)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public global::DocumentIndexer.Implementations.DocumentGrabberAndProcessor Invoke(global::System.String documentsSourcePath, global::DocumentIndexer.Interfaces.IFileSystem fileSystem, global::DocumentIndexer.Interfaces.IDataContextFactory dataContextFactory)
            {
                return this.f1.Invoke(documentsSourcePath, fileSystem, this.f2.Invoke(dataContextFactory));
            }
        
        }
        [DIVEX.Core.CtorOfClassAttribute(typeof(global::DocumentIndexer.Implementations.DocumentWithExtractedWordsStore))]
        public sealed class AdapterForF2
        {
        
            public static implicit operator DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods5.AdapterForF2(DIVEX.Core.ConstructorOf<global::DocumentIndexer.Implementations.DocumentWithExtractedWordsStore> c)
            {
                return new AdapterForF2();
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.OriginalConstructorAttribute("DocumentIndexer.Interfaces.IDataContextFactory")]
            public global::DocumentIndexer.Implementations.DocumentWithExtractedWordsStore Invoke(global::DocumentIndexer.Interfaces.IDataContextFactory dataContextFactory)
            {
                return new global::DocumentIndexer.Implementations.DocumentWithExtractedWordsStore(dataContextFactory);
            }
        
        }
    
    }
}

namespace DocumentIndexer
{
    
    public static class ReplaceWithNamedArgumentsExtensionMethods6
    {
    
        public static DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods6.ReplaceClass Replace(this global::DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods4.ReplaceClass f1, DIVEX.Core.ConstructorOf<global::DocumentIndexer.Implementations.FileSystemBasedDocumentWithExtractedWordsStore> documentWithExtractedWordsStore)
        {
            return new ReplaceClass(f1, documentWithExtractedWordsStore);
        }
        [DIVEX.Core.ReplaceClassAttribute("f1", "f2", "documentWithExtractedWordsStore")]
        public sealed class ReplaceClass
        {
        
            public readonly global::DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods4.ReplaceClass f1;
            public readonly AdapterForF2 f2;
            public ReplaceClass(global::DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods4.ReplaceClass f1, AdapterForF2 f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.ParameterIndexAttribute(4)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public global::DocumentIndexer.Implementations.DocumentGrabberAndProcessor Invoke(global::System.String documentsSourcePath, global::DocumentIndexer.Interfaces.IFileSystem fileSystem, global::System.String extractorServiceUrl, global::DocumentIndexer.Interfaces.IRestClient restClient, global::System.String outputFolderPath, [DIVEX.Core.ParameterNameAttribute("fileSystem")]global::DocumentIndexer.Interfaces.IFileSystem fileSystem1)
            {
                return this.f1.Invoke(documentsSourcePath, fileSystem, extractorServiceUrl, restClient, this.f2.Invoke(outputFolderPath, fileSystem1));
            }
        
        }
        [DIVEX.Core.CtorOfClassAttribute(typeof(global::DocumentIndexer.Implementations.FileSystemBasedDocumentWithExtractedWordsStore))]
        public sealed class AdapterForF2
        {
        
            public static implicit operator DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods6.AdapterForF2(DIVEX.Core.ConstructorOf<global::DocumentIndexer.Implementations.FileSystemBasedDocumentWithExtractedWordsStore> c)
            {
                return new AdapterForF2();
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.OriginalConstructorAttribute("System.String", "DocumentIndexer.Interfaces.IFileSystem")]
            public global::DocumentIndexer.Implementations.FileSystemBasedDocumentWithExtractedWordsStore Invoke(global::System.String outputFolderPath, global::DocumentIndexer.Interfaces.IFileSystem fileSystem)
            {
                return new global::DocumentIndexer.Implementations.FileSystemBasedDocumentWithExtractedWordsStore(outputFolderPath, fileSystem);
            }
        
        }
    
    }
}

namespace DocumentIndexer
{
    
    public static class RenameExtensionMethods1
    {
    
        public static DocumentIndexer.RenameExtensionMethods1.RenameClass Rename(this DIVEX.Core.ConstructorOf<global::DocumentIndexer.Implementations.RestBasedWordsExtractor> f1, Object url_extractorServiceUrl)
        {
            return new RenameClass(f1);
        }
        [DIVEX.Core.RenameClassAttribute("f1", "extractorServiceUrl")]
        public sealed class RenameClass
        {
        
            public readonly AdapterForF1 f1;
            public RenameClass(AdapterForF1 f1)
            {
                this.f1 = f1;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0)]
            [DIVEX.Core.ParameterIndexAttribute(0)]
            public global::DocumentIndexer.Implementations.RestBasedWordsExtractor Invoke(global::System.String extractorServiceUrl, global::DocumentIndexer.Interfaces.IRestClient restClient)
            {
                return this.f1.Invoke(extractorServiceUrl, restClient);
            }
        
        }
        [DIVEX.Core.CtorOfClassAttribute(typeof(global::DocumentIndexer.Implementations.RestBasedWordsExtractor))]
        public sealed class AdapterForF1
        {
        
            public static implicit operator DocumentIndexer.RenameExtensionMethods1.AdapterForF1(DIVEX.Core.ConstructorOf<global::DocumentIndexer.Implementations.RestBasedWordsExtractor> c)
            {
                return new AdapterForF1();
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.OriginalConstructorAttribute("System.String", "DocumentIndexer.Interfaces.IRestClient")]
            public global::DocumentIndexer.Implementations.RestBasedWordsExtractor Invoke(global::System.String url, global::DocumentIndexer.Interfaces.IRestClient restClient)
            {
                return new global::DocumentIndexer.Implementations.RestBasedWordsExtractor(url, restClient);
            }
        
        }
    
    }
}

namespace DocumentIndexer
{
    
    public static class RenameExtensionMethods2
    {
    
        public static DocumentIndexer.RenameExtensionMethods2.RenameClass Rename(this DIVEX.Core.ConstructorOf<global::DocumentIndexer.Implementations.FileSystemDocumentsSource> f1, Object path_documentsSourcePath)
        {
            return new RenameClass(f1);
        }
        [DIVEX.Core.RenameClassAttribute("f1", "documentsSourcePath")]
        public sealed class RenameClass
        {
        
            public readonly AdapterForF1 f1;
            public RenameClass(AdapterForF1 f1)
            {
                this.f1 = f1;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0)]
            [DIVEX.Core.ParameterIndexAttribute(0)]
            public global::DocumentIndexer.Implementations.FileSystemDocumentsSource Invoke(global::System.String documentsSourcePath, global::DocumentIndexer.Interfaces.IFileSystem fileSystem)
            {
                return this.f1.Invoke(documentsSourcePath, fileSystem);
            }
        
        }
        [DIVEX.Core.CtorOfClassAttribute(typeof(global::DocumentIndexer.Implementations.FileSystemDocumentsSource))]
        public sealed class AdapterForF1
        {
        
            public static implicit operator DocumentIndexer.RenameExtensionMethods2.AdapterForF1(DIVEX.Core.ConstructorOf<global::DocumentIndexer.Implementations.FileSystemDocumentsSource> c)
            {
                return new AdapterForF1();
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.OriginalConstructorAttribute("System.String", "DocumentIndexer.Interfaces.IFileSystem")]
            public global::DocumentIndexer.Implementations.FileSystemDocumentsSource Invoke(global::System.String path, global::DocumentIndexer.Interfaces.IFileSystem fileSystem)
            {
                return new global::DocumentIndexer.Implementations.FileSystemDocumentsSource(path, fileSystem);
            }
        
        }
    
    }
}

namespace DocumentIndexer
{
    
    public static class ReplaceOneExtensionMethods1
    {
    
        public static DocumentIndexer.ReplaceOneExtensionMethods1.ReplaceOneClass ReplaceOne(this DIVEX.Core.ConstructorOf<global::DocumentIndexer.Implementations.CompositeRunnable> f1, global::DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods5.ReplaceClass runnables)
        {
            return new ReplaceOneClass(f1, runnables);
        }
        [DIVEX.Core.ReplaceOneClassAttribute("f1", "f2", "runnables")]
        public sealed class ReplaceOneClass
        {
        
            public readonly AdapterForF1 f1;
            public readonly global::DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods5.ReplaceClass f2;
            public ReplaceOneClass(AdapterForF1 f1, global::DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods5.ReplaceClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.ParameterIndexAttribute(0)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public global::DocumentIndexer.Implementations.CompositeRunnable Invoke(global::System.String documentsSourcePath, global::DocumentIndexer.Interfaces.IFileSystem fileSystem, global::DocumentIndexer.Interfaces.IDataContextFactory dataContextFactory, global::DocumentIndexer.Interfaces.IRunnable[] runnables)
            {
                return this.f1.Invoke(global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Concat(new global::DocumentIndexer.Interfaces.IRunnable [] {this.f2.Invoke(documentsSourcePath, fileSystem, dataContextFactory)}, runnables)));
            }
        
        }
        [DIVEX.Core.CtorOfClassAttribute(typeof(global::DocumentIndexer.Implementations.CompositeRunnable))]
        public sealed class AdapterForF1
        {
        
            public static implicit operator DocumentIndexer.ReplaceOneExtensionMethods1.AdapterForF1(DIVEX.Core.ConstructorOf<global::DocumentIndexer.Implementations.CompositeRunnable> c)
            {
                return new AdapterForF1();
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.OriginalConstructorAttribute("DocumentIndexer.Interfaces.IRunnable[]")]
            public global::DocumentIndexer.Implementations.CompositeRunnable Invoke(global::DocumentIndexer.Interfaces.IRunnable[] runnables)
            {
                return new global::DocumentIndexer.Implementations.CompositeRunnable(runnables);
            }
        
        }
    
    }
}

namespace DocumentIndexer
{
    
    public static class ReplaceLastExtensionMethods1
    {
    
        public static DocumentIndexer.ReplaceLastExtensionMethods1.ReplaceLastClass ReplaceLast(this global::DocumentIndexer.ReplaceOneExtensionMethods1.ReplaceOneClass f1, global::DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods6.ReplaceClass runnables)
        {
            return new ReplaceLastClass(f1, runnables);
        }
        [DIVEX.Core.ReplaceLastClassAttribute("f1", "f2", "runnables")]
        public sealed class ReplaceLastClass
        {
        
            public readonly global::DocumentIndexer.ReplaceOneExtensionMethods1.ReplaceOneClass f1;
            public readonly global::DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods6.ReplaceClass f2;
            public ReplaceLastClass(global::DocumentIndexer.ReplaceOneExtensionMethods1.ReplaceOneClass f1, global::DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods6.ReplaceClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.ParameterIndexAttribute(3)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public global::DocumentIndexer.Implementations.CompositeRunnable Invoke(global::System.String documentsSourcePath, global::DocumentIndexer.Interfaces.IFileSystem fileSystem, global::DocumentIndexer.Interfaces.IDataContextFactory dataContextFactory, [DIVEX.Core.ParameterNameAttribute("documentsSourcePath")]global::System.String documentsSourcePath1, [DIVEX.Core.ParameterNameAttribute("fileSystem")]global::DocumentIndexer.Interfaces.IFileSystem fileSystem1, global::System.String extractorServiceUrl, global::DocumentIndexer.Interfaces.IRestClient restClient, global::System.String outputFolderPath, [DIVEX.Core.ParameterNameAttribute("fileSystem")]global::DocumentIndexer.Interfaces.IFileSystem fileSystem2)
            {
                return this.f1.Invoke(documentsSourcePath, fileSystem, dataContextFactory, new global::DocumentIndexer.Interfaces.IRunnable[]{this.f2.Invoke(documentsSourcePath1, fileSystem1, extractorServiceUrl, restClient, outputFolderPath, fileSystem2)});
            }
        
        }
    
    }
}

namespace DocumentIndexer
{
    public  partial class Program
    {
        public sealed partial class VarReturn
        {
        
            [DIVEX.Core.VarReturnClassAttribute()]
            public sealed class VR1
            {
            
                public static implicit operator DocumentIndexer.Program.VarReturn.VR1(global::DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods2.ReplaceClass cfc)
                {
                    return new DocumentIndexer.Program.VarReturn.VR1(cfc);
                }
                public readonly global::DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods2.ReplaceClass cfc;
                public VR1(global::DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods2.ReplaceClass cfc)
                {
                    this.cfc = cfc;
                }
                [DIVEX.Core.InvokeIndexAttribute(0)]
                public global::DocumentIndexer.Implementations.DocumentGrabberAndProcessor Invoke(global::System.String documentsSourcePath, global::DocumentIndexer.Interfaces.IFileSystem fileSystem, global::DocumentIndexer.Interfaces.IWordsExtractor wordsExtractor, global::DocumentIndexer.Interfaces.IDocumentWithExtractedWordsStore documentWithExtractedWordsStore)
                {
                    return this.cfc.Invoke(documentsSourcePath, fileSystem, wordsExtractor, documentWithExtractedWordsStore);
                }
            
            }
        
        }
    }
    
}


