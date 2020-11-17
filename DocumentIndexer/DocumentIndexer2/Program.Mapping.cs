using System;
using DIVEX.Core;

namespace DocumentIndexer
{
    
    public static class ReplaceWithNamedArgumentsExtensionMethods1
    {
    
        public static DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods1.ReplaceClass Replace(this DIVEX.Core.ConstructorOf<global::DocumentIndexer.Implementations.DocumentGrabberAndProcessor> f1, global::DocumentIndexer.RenameExtensionMethods1.RenameClass documentsSource)
        {
            return new ReplaceClass(f1, documentsSource);
        }
        [DIVEX.Core.ReplaceClassAttribute("f1", "f2", "documentsSource")]
        public sealed class ReplaceClass
        {
        
            public readonly AdapterForF1 f1;
            public readonly global::DocumentIndexer.RenameExtensionMethods1.RenameClass f2;
            public ReplaceClass(AdapterForF1 f1, global::DocumentIndexer.RenameExtensionMethods1.RenameClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.ParameterIndexAttribute(0)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public global::DocumentIndexer.Implementations.DocumentGrabberAndProcessor Invoke(global::System.String documentsSourcePath, global::DocumentIndexer.Interfaces.IDocumentProcessor documentProcessor)
            {
                return this.f1.Invoke(this.f2.Invoke(documentsSourcePath), documentProcessor);
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
            [DIVEX.Core.ParameterIndexAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public global::DocumentIndexer.Implementations.DocumentGrabberAndProcessor Invoke(global::System.String documentsSourcePath, global::DocumentIndexer.Interfaces.IWordsExtractor wordsExtractor, global::DocumentIndexer.Interfaces.IDocumentWithExtractedWordsStore documentWithExtractedWordsStore)
            {
                return this.f1.Invoke(documentsSourcePath, this.f2.Invoke(wordsExtractor, documentWithExtractedWordsStore));
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
    
        public static DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods3.ReplaceClass Replace(this global::DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods2.ReplaceClass f1, DIVEX.Core.ConstructorOf<global::DocumentIndexer.Implementations.SimpleWordsExtractor> wordsExtractor)
        {
            return new ReplaceClass(f1, wordsExtractor);
        }
        [DIVEX.Core.ReplaceClassAttribute("f1", "f2", "wordsExtractor")]
        public sealed class ReplaceClass
        {
        
            public readonly global::DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods2.ReplaceClass f1;
            public readonly AdapterForF2 f2;
            public ReplaceClass(global::DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods2.ReplaceClass f1, AdapterForF2 f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.ParameterIndexAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public global::DocumentIndexer.Implementations.DocumentGrabberAndProcessor Invoke(global::System.String documentsSourcePath, global::DocumentIndexer.Interfaces.IDocumentWithExtractedWordsStore documentWithExtractedWordsStore)
            {
                return this.f1.Invoke(documentsSourcePath, this.f2.Invoke(), documentWithExtractedWordsStore);
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
    
        public static DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods4.ReplaceClass Replace(this global::DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods3.ReplaceClass f1, DIVEX.Core.ConstructorOf<global::DocumentIndexer.Implementations.DocumentWithExtractedWordsStore> documentWithExtractedWordsStore)
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
            [DIVEX.Core.ParameterIndexAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public global::DocumentIndexer.Implementations.DocumentGrabberAndProcessor Invoke(global::System.String documentsSourcePath, global::DocumentIndexer.Interfaces.IDataContextFactory dataContextIsolationFactory)
            {
                return this.f1.Invoke(documentsSourcePath, this.f2.Invoke(dataContextIsolationFactory));
            }
        
        }
        [DIVEX.Core.CtorOfClassAttribute(typeof(global::DocumentIndexer.Implementations.DocumentWithExtractedWordsStore))]
        public sealed class AdapterForF2
        {
        
            public static implicit operator DocumentIndexer.ReplaceWithNamedArgumentsExtensionMethods4.AdapterForF2(DIVEX.Core.ConstructorOf<global::DocumentIndexer.Implementations.DocumentWithExtractedWordsStore> c)
            {
                return new AdapterForF2();
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.OriginalConstructorAttribute("DocumentIndexer.Interfaces.IDataContextFactory")]
            public global::DocumentIndexer.Implementations.DocumentWithExtractedWordsStore Invoke(global::DocumentIndexer.Interfaces.IDataContextFactory dataContextIsolationFactory)
            {
                return new global::DocumentIndexer.Implementations.DocumentWithExtractedWordsStore(dataContextIsolationFactory);
            }
        
        }
    
    }
}

namespace DocumentIndexer
{
    
    public static class RenameExtensionMethods1
    {
    
        public static DocumentIndexer.RenameExtensionMethods1.RenameClass Rename(this DIVEX.Core.ConstructorOf<global::DocumentIndexer.Implementations.FileSystemDocumentsSource> f1, Object path_documentsSourcePath)
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
            public global::DocumentIndexer.Implementations.FileSystemDocumentsSource Invoke(global::System.String documentsSourcePath)
            {
                return this.f1.Invoke(documentsSourcePath);
            }
        
        }
        [DIVEX.Core.CtorOfClassAttribute(typeof(global::DocumentIndexer.Implementations.FileSystemDocumentsSource))]
        public sealed class AdapterForF1
        {
        
            public static implicit operator DocumentIndexer.RenameExtensionMethods1.AdapterForF1(DIVEX.Core.ConstructorOf<global::DocumentIndexer.Implementations.FileSystemDocumentsSource> c)
            {
                return new AdapterForF1();
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.OriginalConstructorAttribute("System.String")]
            public global::DocumentIndexer.Implementations.FileSystemDocumentsSource Invoke(global::System.String path)
            {
                return new global::DocumentIndexer.Implementations.FileSystemDocumentsSource(path);
            }
        
        }
    
    }
}



