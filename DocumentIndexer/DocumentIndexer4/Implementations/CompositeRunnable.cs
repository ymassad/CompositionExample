using DocumentIndexer.Interfaces;

namespace DocumentIndexer.Implementations
{
    public class CompositeRunnable : IRunnable
    {
        private readonly IRunnable[] runnables;

        public CompositeRunnable(IRunnable[] runnables)
        {
            this.runnables = runnables;
        }

        public void Run()
        {
            foreach (var runnable in runnables)
                runnable.Run();
        }
    }
}