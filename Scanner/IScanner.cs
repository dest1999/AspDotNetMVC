using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scanner
{
    public interface IScanner
    {
        int CPULoad { get; }
        int RAMLoad { get; }
        byte[] GetSequence(string source);
    }
}
