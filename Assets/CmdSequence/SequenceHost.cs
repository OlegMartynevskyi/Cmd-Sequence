using System;

namespace CmdSequence
{
    public sealed class SequenceHost : Sequence
    {
        public Action OnStart;
        public Action OnStop;
        public Action<ICmd> OnExecuteCmd;

        private bool started;
        private bool canMove;

        public SequenceHost(params ICmd[] commands)
            : base(commands)
        { }

        public override bool MoveNext()
        {
            if (!started)
            {
                if (OnStart != null)
                {
                    OnStart();
                }                    
                started = true;
            }
            canMove = cmdList[current].MoveNext();
            if (OnExecuteCmd != null)
            {
                OnExecuteCmd(cmdList[current]);
            }   
            if (!canMove)
            {
                ++current;
                if (Finish && OnStop != null)
                {
                    OnStop();
                }
            }
            return !Finish;
        }

        public override void Reset()
        {
            base.Reset();
            started = false;
        }
    }
}
