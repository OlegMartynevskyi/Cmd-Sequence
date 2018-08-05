using UnityEngine;

namespace CmdSequence
{
    public static class SequencePlayer
    {
        public static void Play(this MonoBehaviour monoBehaviour, Sequence sequence)
        {
            monoBehaviour.StartCoroutine(sequence);
        }
    }
}