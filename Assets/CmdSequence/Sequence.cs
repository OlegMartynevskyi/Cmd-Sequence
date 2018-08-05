using System.Collections;

namespace CmdSequence
{
    public class Sequence : ICmd
    {
        protected readonly ICmd[] cmdList;

        protected int current;

        object IEnumerator.Current { get { return null; } }        

        public bool Finish { get { return current >= cmdList.Length; } }        

        public Sequence(params ICmd[] commands)
        {
            cmdList = commands;
        }

        public virtual bool MoveNext()
        {
            if (!cmdList[current].MoveNext())
            {
                ++current;
            }                
            return !Finish;
        }

        public virtual void Reset()
        {
            cmdList[current].Reset();
            current = 0;
        }        
    }
}
