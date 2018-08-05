using UnityEngine;

namespace CmdSequence
{
    [System.Serializable]
    sealed class DebugCmd : BaseCmd
    {
        [SerializeField]
        private string debugText;

        public DebugCmd(string text)
        {
            debugText = text;
        }

        protected override void Execute()
        {
            Debug.Log(debugText);
            End();
        }

        public override string ToString()
        {
            return "Debug Cmd " + debugText;
        }
    }
}
