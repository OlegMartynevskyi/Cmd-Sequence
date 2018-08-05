using System.Collections;

namespace CmdSequence
{
    internal abstract class BaseCmd : ICmd
    {
        object IEnumerator.Current { get { return null; } }

        public bool Finish { get; private set; }        

        public bool MoveNext()
        {
            Execute();
            return !Finish;
        }

        public virtual void Reset()
        {
            Finish = false;
        }

        protected abstract void Execute();

        protected void End()
        {
            Finish = true;
        }
    }
}
