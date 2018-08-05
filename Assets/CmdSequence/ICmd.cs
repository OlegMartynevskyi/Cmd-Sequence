using System.Collections;

namespace CmdSequence
{
    public interface ICmd : IEnumerator
    {
        bool Finish { get; }
    }
}
