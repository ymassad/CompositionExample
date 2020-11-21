using System;
using DIVEX.Core;

namespace DocumentIndexer
{
    public partial class Program
{
    [DIVEX.Core.OriginalClassTypeAttribute(typeof(global::DocumentIndexer.Implementations.RestModule))]
public static partial class RestModule
{
    public static DocumentIndexer.Program.RestModule.GetWordsUsingRestServiceToFunctionClass GetWordsUsingRestService
    {
        get
        {
            return new DocumentIndexer.Program.RestModule.GetWordsUsingRestServiceToFunctionClass();
        }
    }

    [DIVEX.Core.FunctionReferenceClassAttribute("DocumentIndexer.Implementations.RestModule", "GetWordsUsingRestService")]
    public sealed class GetWordsUsingRestServiceToFunctionClass
    {
    
        [DIVEX.Core.ReplacedDelegateAttribute(1)]
        public  delegate global::System.String ParameterDelegate0n2(global::System.Uri url, global::System.String body);
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("GetWordsUsingRestService", 0, "System.Uri", "System.Func<System.Uri, System.String, System.String>", "System.String")]
        public global::System.String[] Invoke(global::System.Uri url, ParameterDelegate0n2 post, global::System.String content)
        {
            return global::DocumentIndexer.Implementations.RestModule.GetWordsUsingRestService(url, (post is null) ? null : new global::System.Func<global::System.Uri, global::System.String, global::System.String>(post), content);
        }
    
    }

}
[DIVEX.Core.OriginalClassTypeAttribute(typeof(global::DocumentIndexer.Implementations.MainModule))]
public static partial class MainModule
{
    public static DocumentIndexer.Program.MainModule.RunMultipleToFunctionClass RunMultiple
    {
        get
        {
            return new DocumentIndexer.Program.MainModule.RunMultipleToFunctionClass();
        }
    }
    public static DocumentIndexer.Program.MainModule.GrabAndProcessorDocumentsToFunctionClass GrabAndProcessorDocuments
    {
        get
        {
            return new DocumentIndexer.Program.MainModule.GrabAndProcessorDocumentsToFunctionClass();
        }
    }
    public static DocumentIndexer.Program.MainModule.IndexDocumentToFunctionClass IndexDocument
    {
        get
        {
            return new DocumentIndexer.Program.MainModule.IndexDocumentToFunctionClass();
        }
    }
    public static DocumentIndexer.Program.MainModule.GetWordsToFunctionClass GetWords
    {
        get
        {
            return new DocumentIndexer.Program.MainModule.GetWordsToFunctionClass();
        }
    }

    [DIVEX.Core.FunctionReferenceClassAttribute("DocumentIndexer.Implementations.MainModule", "RunMultiple")]
    public sealed class RunMultipleToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("RunMultiple", 0, "System.Action[]")]
        public void Invoke(global::System.Action[] runnables)
        {
            global::DocumentIndexer.Implementations.MainModule.RunMultiple(runnables);
        }
    
    }
    [DIVEX.Core.FunctionReferenceClassAttribute("DocumentIndexer.Implementations.MainModule", "GrabAndProcessorDocuments")]
    public sealed class GrabAndProcessorDocumentsToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("GrabAndProcessorDocuments", 0, "System.Func<DocumentIndexer.Interfaces.DTOs.InputDocument[]>", "System.Action<DocumentIndexer.Interfaces.DTOs.InputDocument>")]
        public void Invoke(global::System.Func<global::DocumentIndexer.Interfaces.DTOs.InputDocument[]> getDocuments, global::System.Action<global::DocumentIndexer.Interfaces.DTOs.InputDocument> processDocument)
        {
            global::DocumentIndexer.Implementations.MainModule.GrabAndProcessorDocuments(getDocuments, processDocument);
        }
    
    }
    [DIVEX.Core.FunctionReferenceClassAttribute("DocumentIndexer.Implementations.MainModule", "IndexDocument")]
    public sealed class IndexDocumentToFunctionClass
    {
    
        [DIVEX.Core.ReplacedDelegateAttribute(0)]
        public  delegate global::System.String[] ParameterDelegate0n1(global::System.String documentContent);
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("IndexDocument", 0, "System.Func<System.String, System.String[]>", "System.Action<DocumentIndexer.Interfaces.DTOs.InputDocumentWithExtractedWords>", "DocumentIndexer.Interfaces.DTOs.InputDocument")]
        public void Invoke(ParameterDelegate0n1 extractWords, global::System.Action<global::DocumentIndexer.Interfaces.DTOs.InputDocumentWithExtractedWords> storeDocumentWithExtractedWords, global::DocumentIndexer.Interfaces.DTOs.InputDocument inputDocument)
        {
            global::DocumentIndexer.Implementations.MainModule.IndexDocument((extractWords is null) ? null : new global::System.Func<global::System.String, global::System.String[]>(extractWords), storeDocumentWithExtractedWords, inputDocument);
        }
    
    }
    [DIVEX.Core.FunctionReferenceClassAttribute("DocumentIndexer.Implementations.MainModule", "GetWords")]
    public sealed class GetWordsToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("GetWords", 0, "System.String")]
        public global::System.String[] Invoke(global::System.String content)
        {
            return global::DocumentIndexer.Implementations.MainModule.GetWords(content);
        }
    
    }

}
[DIVEX.Core.OriginalClassTypeAttribute(typeof(global::DocumentIndexer.Implementations.StorageModule))]
public static partial class StorageModule
{
    public static DocumentIndexer.Program.StorageModule.StoreToTheDatabaseToFunctionClass StoreToTheDatabase
    {
        get
        {
            return new DocumentIndexer.Program.StorageModule.StoreToTheDatabaseToFunctionClass();
        }
    }
    public static DocumentIndexer.Program.StorageModule.StoreToTheFileSystemToFunctionClass StoreToTheFileSystem
    {
        get
        {
            return new DocumentIndexer.Program.StorageModule.StoreToTheFileSystemToFunctionClass();
        }
    }
    public static DocumentIndexer.Program.StorageModule.GetDocumentsFromFileSystemToFunctionClass GetDocumentsFromFileSystem
    {
        get
        {
            return new DocumentIndexer.Program.StorageModule.GetDocumentsFromFileSystemToFunctionClass();
        }
    }

    [DIVEX.Core.FunctionReferenceClassAttribute("DocumentIndexer.Implementations.StorageModule", "StoreToTheDatabase")]
    public sealed class StoreToTheDatabaseToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("StoreToTheDatabase", 0, "System.Func<DocumentIndexer.Data.DataContext>", "DocumentIndexer.Interfaces.DTOs.InputDocumentWithExtractedWords")]
        public void Invoke(global::System.Func<global::DocumentIndexer.Data.DataContext> createDataContext, global::DocumentIndexer.Interfaces.DTOs.InputDocumentWithExtractedWords inputDocumentWithExtractedWords)
        {
            global::DocumentIndexer.Implementations.StorageModule.StoreToTheDatabase(createDataContext, inputDocumentWithExtractedWords);
        }
    
    }
    [DIVEX.Core.FunctionReferenceClassAttribute("DocumentIndexer.Implementations.StorageModule", "StoreToTheFileSystem")]
    public sealed class StoreToTheFileSystemToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("StoreToTheFileSystem", 0, "System.String", "System.IO.Abstractions.IFileSystem", "DocumentIndexer.Interfaces.DTOs.InputDocumentWithExtractedWords")]
        public void Invoke(global::System.String outputFolderPath, global::System.IO.Abstractions.IFileSystem fileSystem, global::DocumentIndexer.Interfaces.DTOs.InputDocumentWithExtractedWords inputDocumentWithExtractedWords)
        {
            global::DocumentIndexer.Implementations.StorageModule.StoreToTheFileSystem(outputFolderPath, fileSystem, inputDocumentWithExtractedWords);
        }
    
    }
    [DIVEX.Core.FunctionReferenceClassAttribute("DocumentIndexer.Implementations.StorageModule", "GetDocumentsFromFileSystem")]
    public sealed class GetDocumentsFromFileSystemToFunctionClass
    {
    
        [DIVEX.Core.InvokeIndexAttribute(0)]
        [DIVEX.Core.OriginalMethodAttribute("GetDocumentsFromFileSystem", 0, "System.String", "System.IO.Abstractions.IFileSystem")]
        public global::DocumentIndexer.Interfaces.DTOs.InputDocument[] Invoke(global::System.String path, global::System.IO.Abstractions.IFileSystem fileSystem)
        {
            return global::DocumentIndexer.Implementations.StorageModule.GetDocumentsFromFileSystem(path, fileSystem);
        }
    
    }

}
}
}
namespace DocumentIndexer
{
    
    public static class JoinAllInputsExtensionMethods1
    {
    
        public static DocumentIndexer.JoinAllInputsExtensionMethods1.JoinAllInputsClass JoinAllInputs(this global::DocumentIndexer.InjectLastExtensionMethods1.InjectLastClass function)
        {
            return new JoinAllInputsClass(function);
        }
        [DIVEX.Core.JoinAllInputsClassAttribute("function")]
        public sealed class JoinAllInputsClass
        {
        
            public readonly global::DocumentIndexer.InjectLastExtensionMethods1.InjectLastClass function;
            public JoinAllInputsClass(global::DocumentIndexer.InjectLastExtensionMethods1.InjectLastClass function)
            {
                this.function = function;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0)]
            [DIVEX.Core.JoinedParametersDetailsAttribute("(0;3),(1;4;8),2,5,6,7")]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            public void Invoke(global::System.String documentsSourcePath, global::System.IO.Abstractions.IFileSystem fileSystem, global::System.Func<global::DocumentIndexer.Data.DataContext> createDataContext, global::System.Uri extractorServiceUrl, global::DocumentIndexer.Program.RestModule.GetWordsUsingRestServiceToFunctionClass.ParameterDelegate0n2 post, global::System.String outputFolderPath)
            {
                this.function.Invoke(documentsSourcePath,fileSystem,new global::System.Func<global::DocumentIndexer.Data.DataContext>(createDataContext),documentsSourcePath,fileSystem,extractorServiceUrl,new global::DocumentIndexer.Program.RestModule.GetWordsUsingRestServiceToFunctionClass.ParameterDelegate0n2(post),outputFolderPath,fileSystem);
            }
        
        }
    
    }
}

namespace DocumentIndexer
{
    
    public static class InjectOneExtensionMethods1
    {
    
        public static DocumentIndexer.InjectOneExtensionMethods1.InjectOneClass InjectOne(this global::DocumentIndexer.Program.MainModule.RunMultipleToFunctionClass f1, global::DocumentIndexer.InjectWithNamedArgumentsExtensionMethods5.InjectClass runnables)
        {
            return new InjectOneClass(f1, runnables);
        }
        [DIVEX.Core.InjectOneClassAttribute("f1", "f2")]
        public sealed class InjectOneClass
        {
        
            public readonly global::DocumentIndexer.Program.MainModule.RunMultipleToFunctionClass f1;
            public readonly global::DocumentIndexer.InjectWithNamedArgumentsExtensionMethods5.InjectClass f2;
            public InjectOneClass(global::DocumentIndexer.Program.MainModule.RunMultipleToFunctionClass f1, global::DocumentIndexer.InjectWithNamedArgumentsExtensionMethods5.InjectClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute()]
            [DIVEX.Core.ParameterIndexAttribute(0)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public void Invoke(global::System.String documentsSourcePath, global::System.IO.Abstractions.IFileSystem fileSystem, global::System.Func<global::DocumentIndexer.Data.DataContext> createDataContext, global::System.Action[] runnables)
            {
                this.f1.Invoke(global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Concat(new global::System.Action [] {() => this.f2.Invoke(documentsSourcePath, fileSystem, createDataContext)}, runnables)));
            }
        
        }
    
    }
}

namespace DocumentIndexer
{
    
    public static class InjectLastExtensionMethods1
    {
    
        public static DocumentIndexer.InjectLastExtensionMethods1.InjectLastClass InjectLast(this global::DocumentIndexer.InjectOneExtensionMethods1.InjectOneClass f1, global::DocumentIndexer.InjectWithNamedArgumentsExtensionMethods6.InjectClass runnables)
        {
            return new InjectLastClass(f1, runnables);
        }
        [DIVEX.Core.InjectLastClassAttribute("f1", "f2")]
        public sealed class InjectLastClass
        {
        
            public readonly global::DocumentIndexer.InjectOneExtensionMethods1.InjectOneClass f1;
            public readonly global::DocumentIndexer.InjectWithNamedArgumentsExtensionMethods6.InjectClass f2;
            public InjectLastClass(global::DocumentIndexer.InjectOneExtensionMethods1.InjectOneClass f1, global::DocumentIndexer.InjectWithNamedArgumentsExtensionMethods6.InjectClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute()]
            [DIVEX.Core.ParameterIndexAttribute(3)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public void Invoke(global::System.String documentsSourcePath, global::System.IO.Abstractions.IFileSystem fileSystem, global::System.Func<global::DocumentIndexer.Data.DataContext> createDataContext, [DIVEX.Core.ParameterNameAttribute("documentsSourcePath")]global::System.String documentsSourcePath1, [DIVEX.Core.ParameterNameAttribute("fileSystem")]global::System.IO.Abstractions.IFileSystem fileSystem1, global::System.Uri extractorServiceUrl, global::DocumentIndexer.Program.RestModule.GetWordsUsingRestServiceToFunctionClass.ParameterDelegate0n2 post, global::System.String outputFolderPath, [DIVEX.Core.ParameterNameAttribute("fileSystem")]global::System.IO.Abstractions.IFileSystem fileSystem2)
            {
                this.f1.Invoke(documentsSourcePath, fileSystem, createDataContext, new global::System.Action[]{() => this.f2.Invoke(documentsSourcePath1, fileSystem1, extractorServiceUrl, post, outputFolderPath, fileSystem2)});
            }
        
        }
    
    }
}

namespace DocumentIndexer
{
    
    public static class InjectWithNamedArgumentsExtensionMethods1
    {
    
        public static DocumentIndexer.InjectWithNamedArgumentsExtensionMethods1.InjectClass Inject(this global::DocumentIndexer.Program.MainModule.GrabAndProcessorDocumentsToFunctionClass f1, global::DocumentIndexer.RenameExtensionMethods1.RenameClass getDocuments)
        {
            return new InjectClass(f1, getDocuments);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::DocumentIndexer.Program.MainModule.GrabAndProcessorDocumentsToFunctionClass f1;
            public readonly global::DocumentIndexer.RenameExtensionMethods1.RenameClass f2;
            public InjectClass(global::DocumentIndexer.Program.MainModule.GrabAndProcessorDocumentsToFunctionClass f1, global::DocumentIndexer.RenameExtensionMethods1.RenameClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute()]
            [DIVEX.Core.ParameterIndexAttribute(0)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public void Invoke(global::System.String documentsSourcePath, global::System.IO.Abstractions.IFileSystem fileSystem, global::System.Action<global::DocumentIndexer.Interfaces.DTOs.InputDocument> processDocument)
            {
                this.f1.Invoke(() => this.f2.Invoke(documentsSourcePath, fileSystem), processDocument);
            }
        
        }
    
    }
}

namespace DocumentIndexer
{
    
    public static class InjectWithNamedArgumentsExtensionMethods2
    {
    
        public static DocumentIndexer.InjectWithNamedArgumentsExtensionMethods2.InjectClass Inject(this global::DocumentIndexer.InjectWithNamedArgumentsExtensionMethods1.InjectClass f1, global::DocumentIndexer.Program.MainModule.IndexDocumentToFunctionClass processDocument)
        {
            return new InjectClass(f1, processDocument);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::DocumentIndexer.InjectWithNamedArgumentsExtensionMethods1.InjectClass f1;
            public readonly global::DocumentIndexer.Program.MainModule.IndexDocumentToFunctionClass f2;
            public InjectClass(global::DocumentIndexer.InjectWithNamedArgumentsExtensionMethods1.InjectClass f1, global::DocumentIndexer.Program.MainModule.IndexDocumentToFunctionClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute(2)]
            [DIVEX.Core.ParameterIndexAttribute(2)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public void Invoke(global::System.String documentsSourcePath, global::System.IO.Abstractions.IFileSystem fileSystem, global::DocumentIndexer.Program.MainModule.IndexDocumentToFunctionClass.ParameterDelegate0n1 extractWords, global::System.Action<global::DocumentIndexer.Interfaces.DTOs.InputDocumentWithExtractedWords> storeDocumentWithExtractedWords)
            {
                this.f1.Invoke(documentsSourcePath, fileSystem, obj => this.f2.Invoke(extractWords, storeDocumentWithExtractedWords, obj));
            }
        
        }
    
    }
}

namespace DocumentIndexer
{
    
    public static class InjectWithNamedArgumentsExtensionMethods3
    {
    
        public static DocumentIndexer.InjectWithNamedArgumentsExtensionMethods3.InjectClass Inject(this global::DocumentIndexer.Program.VarReturn.VR1 f1, global::DocumentIndexer.Program.MainModule.GetWordsToFunctionClass extractWords)
        {
            return new InjectClass(f1, extractWords);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::DocumentIndexer.Program.VarReturn.VR1 f1;
            public readonly global::DocumentIndexer.Program.MainModule.GetWordsToFunctionClass f2;
            public InjectClass(global::DocumentIndexer.Program.VarReturn.VR1 f1, global::DocumentIndexer.Program.MainModule.GetWordsToFunctionClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute(0)]
            [DIVEX.Core.ParameterIndexAttribute(2)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public void Invoke(global::System.String documentsSourcePath, global::System.IO.Abstractions.IFileSystem fileSystem, global::System.Action<global::DocumentIndexer.Interfaces.DTOs.InputDocumentWithExtractedWords> storeDocumentWithExtractedWords)
            {
                this.f1.Invoke(documentsSourcePath, fileSystem, documentContent => this.f2.Invoke(documentContent), storeDocumentWithExtractedWords);
            }
        
        }
    
    }
}

namespace DocumentIndexer
{
    
    public static class InjectWithNamedArgumentsExtensionMethods4
    {
    
        public static DocumentIndexer.InjectWithNamedArgumentsExtensionMethods4.InjectClass Inject(this global::DocumentIndexer.Program.VarReturn.VR1 f1, global::DocumentIndexer.Program.RestModule.GetWordsUsingRestServiceToFunctionClass extractWords)
        {
            return new InjectClass(f1, extractWords);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::DocumentIndexer.Program.VarReturn.VR1 f1;
            public readonly global::DocumentIndexer.Program.RestModule.GetWordsUsingRestServiceToFunctionClass f2;
            public InjectClass(global::DocumentIndexer.Program.VarReturn.VR1 f1, global::DocumentIndexer.Program.RestModule.GetWordsUsingRestServiceToFunctionClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute(2)]
            [DIVEX.Core.ParameterIndexAttribute(2)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public void Invoke(global::System.String documentsSourcePath, global::System.IO.Abstractions.IFileSystem fileSystem, global::System.Uri url, global::DocumentIndexer.Program.RestModule.GetWordsUsingRestServiceToFunctionClass.ParameterDelegate0n2 post, global::System.Action<global::DocumentIndexer.Interfaces.DTOs.InputDocumentWithExtractedWords> storeDocumentWithExtractedWords)
            {
                this.f1.Invoke(documentsSourcePath, fileSystem, documentContent => this.f2.Invoke(url, post, documentContent), storeDocumentWithExtractedWords);
            }
        
        }
    
    }
}

namespace DocumentIndexer
{
    
    public static class InjectWithNamedArgumentsExtensionMethods5
    {
    
        public static DocumentIndexer.InjectWithNamedArgumentsExtensionMethods5.InjectClass Inject(this global::DocumentIndexer.InjectWithNamedArgumentsExtensionMethods3.InjectClass f1, global::DocumentIndexer.Program.StorageModule.StoreToTheDatabaseToFunctionClass storeDocumentWithExtractedWords)
        {
            return new InjectClass(f1, storeDocumentWithExtractedWords);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::DocumentIndexer.InjectWithNamedArgumentsExtensionMethods3.InjectClass f1;
            public readonly global::DocumentIndexer.Program.StorageModule.StoreToTheDatabaseToFunctionClass f2;
            public InjectClass(global::DocumentIndexer.InjectWithNamedArgumentsExtensionMethods3.InjectClass f1, global::DocumentIndexer.Program.StorageModule.StoreToTheDatabaseToFunctionClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute(1)]
            [DIVEX.Core.ParameterIndexAttribute(2)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public void Invoke(global::System.String documentsSourcePath, global::System.IO.Abstractions.IFileSystem fileSystem, global::System.Func<global::DocumentIndexer.Data.DataContext> createDataContext)
            {
                this.f1.Invoke(documentsSourcePath, fileSystem, obj => this.f2.Invoke(createDataContext, obj));
            }
        
        }
    
    }
}

namespace DocumentIndexer
{
    
    public static class InjectWithNamedArgumentsExtensionMethods6
    {
    
        public static DocumentIndexer.InjectWithNamedArgumentsExtensionMethods6.InjectClass Inject(this global::DocumentIndexer.RenameExtensionMethods2.RenameClass f1, global::DocumentIndexer.Program.StorageModule.StoreToTheFileSystemToFunctionClass storeDocumentWithExtractedWords)
        {
            return new InjectClass(f1, storeDocumentWithExtractedWords);
        }
        [DIVEX.Core.InjectClassAttribute("f1", "f2")]
        public sealed class InjectClass
        {
        
            public readonly global::DocumentIndexer.RenameExtensionMethods2.RenameClass f1;
            public readonly global::DocumentIndexer.Program.StorageModule.StoreToTheFileSystemToFunctionClass f2;
            public InjectClass(global::DocumentIndexer.RenameExtensionMethods2.RenameClass f1, global::DocumentIndexer.Program.StorageModule.StoreToTheFileSystemToFunctionClass f2)
            {
                this.f1 = f1;
                this.f2 = f2;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0, 0)]
            [DIVEX.Core.InjectMapAttribute(2)]
            [DIVEX.Core.ParameterIndexAttribute(4)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(1)]
            [DIVEX.Core.TypeArgsForFunctionXAttribute(2)]
            public void Invoke(global::System.String documentsSourcePath, global::System.IO.Abstractions.IFileSystem fileSystem, global::System.Uri extractorServiceUrl, global::DocumentIndexer.Program.RestModule.GetWordsUsingRestServiceToFunctionClass.ParameterDelegate0n2 post, global::System.String outputFolderPath, [DIVEX.Core.ParameterNameAttribute("fileSystem")]global::System.IO.Abstractions.IFileSystem fileSystem1)
            {
                this.f1.Invoke(documentsSourcePath, fileSystem, extractorServiceUrl, post, obj => this.f2.Invoke(outputFolderPath, fileSystem1, obj));
            }
        
        }
    
    }
}

namespace DocumentIndexer
{
    
    public static class RenameExtensionMethods1
    {
    
        public static DocumentIndexer.RenameExtensionMethods1.RenameClass Rename(this global::DocumentIndexer.Program.StorageModule.GetDocumentsFromFileSystemToFunctionClass f1, Object path_documentsSourcePath)
        {
            return new RenameClass(f1);
        }
        [DIVEX.Core.RenameClassAttribute("f1", "documentsSourcePath")]
        public sealed class RenameClass
        {
        
            public readonly global::DocumentIndexer.Program.StorageModule.GetDocumentsFromFileSystemToFunctionClass f1;
            public RenameClass(global::DocumentIndexer.Program.StorageModule.GetDocumentsFromFileSystemToFunctionClass f1)
            {
                this.f1 = f1;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0)]
            [DIVEX.Core.ParameterIndexAttribute(0)]
            public global::DocumentIndexer.Interfaces.DTOs.InputDocument[] Invoke(global::System.String documentsSourcePath, global::System.IO.Abstractions.IFileSystem fileSystem)
            {
                return this.f1.Invoke(documentsSourcePath, fileSystem);
            }
        
        }
    
    }
}

namespace DocumentIndexer
{
    
    public static class RenameExtensionMethods2
    {
    
        public static DocumentIndexer.RenameExtensionMethods2.RenameClass Rename(this global::DocumentIndexer.InjectWithNamedArgumentsExtensionMethods4.InjectClass f1, Object url_extractorServiceUrl)
        {
            return new RenameClass(f1);
        }
        [DIVEX.Core.RenameClassAttribute("f1", "extractorServiceUrl")]
        public sealed class RenameClass
        {
        
            public readonly global::DocumentIndexer.InjectWithNamedArgumentsExtensionMethods4.InjectClass f1;
            public RenameClass(global::DocumentIndexer.InjectWithNamedArgumentsExtensionMethods4.InjectClass f1)
            {
                this.f1 = f1;
            }
            [DIVEX.Core.InvokeIndexAttribute(0)]
            [DIVEX.Core.IndexesOfUsedInvokablesAttribute(0)]
            [DIVEX.Core.ParameterIndexAttribute(2)]
            public void Invoke(global::System.String documentsSourcePath, global::System.IO.Abstractions.IFileSystem fileSystem, global::System.Uri extractorServiceUrl, global::DocumentIndexer.Program.RestModule.GetWordsUsingRestServiceToFunctionClass.ParameterDelegate0n2 post, global::System.Action<global::DocumentIndexer.Interfaces.DTOs.InputDocumentWithExtractedWords> storeDocumentWithExtractedWords)
            {
                this.f1.Invoke(documentsSourcePath, fileSystem, extractorServiceUrl, post, storeDocumentWithExtractedWords);
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
            
                public static implicit operator DocumentIndexer.Program.VarReturn.VR1(global::DocumentIndexer.InjectWithNamedArgumentsExtensionMethods2.InjectClass cfc)
                {
                    return new DocumentIndexer.Program.VarReturn.VR1(cfc);
                }
                public readonly global::DocumentIndexer.InjectWithNamedArgumentsExtensionMethods2.InjectClass cfc;
                public VR1(global::DocumentIndexer.InjectWithNamedArgumentsExtensionMethods2.InjectClass cfc)
                {
                    this.cfc = cfc;
                }
                [DIVEX.Core.InvokeIndexAttribute(0)]
                public void Invoke(global::System.String documentsSourcePath, global::System.IO.Abstractions.IFileSystem fileSystem, global::DocumentIndexer.Program.MainModule.IndexDocumentToFunctionClass.ParameterDelegate0n1 extractWords, global::System.Action<global::DocumentIndexer.Interfaces.DTOs.InputDocumentWithExtractedWords> storeDocumentWithExtractedWords)
                {
                    this.cfc.Invoke(documentsSourcePath, fileSystem, extractWords, storeDocumentWithExtractedWords);
                }
            
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
            public sealed class VR2
            {
            
                public static implicit operator DocumentIndexer.Program.VarReturn.VR2(global::DocumentIndexer.JoinAllInputsExtensionMethods1.JoinAllInputsClass cfc)
                {
                    return new DocumentIndexer.Program.VarReturn.VR2(cfc);
                }
                public readonly global::DocumentIndexer.JoinAllInputsExtensionMethods1.JoinAllInputsClass cfc;
                public VR2(global::DocumentIndexer.JoinAllInputsExtensionMethods1.JoinAllInputsClass cfc)
                {
                    this.cfc = cfc;
                }
                [DIVEX.Core.InvokeIndexAttribute(0)]
                public void Invoke(global::System.String documentsSourcePath, global::System.IO.Abstractions.IFileSystem fileSystem, global::System.Func<global::DocumentIndexer.Data.DataContext> createDataContext, global::System.Uri extractorServiceUrl, global::DocumentIndexer.Program.RestModule.GetWordsUsingRestServiceToFunctionClass.ParameterDelegate0n2 post, global::System.String outputFolderPath)
                {
                    this.cfc.Invoke(documentsSourcePath, fileSystem, createDataContext, extractorServiceUrl, post, outputFolderPath);
                }
            
            }
        
        }
    }
    
}


