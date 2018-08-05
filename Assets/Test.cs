using CmdSequence;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField]
    private DebugCmd[] debugCmds;

    private void Start()
    {
        var sequence = new SequenceHost(debugCmds);
        sequence.OnStart = () => Debug.Log("Begin sequence");
        sequence.OnStop = () => Debug.Log("End sequence");
        sequence.OnExecuteCmd = (cmd) => Debug.Log("Execute cmd: " + cmd.ToString());
        this.Play(sequence);
    }
}