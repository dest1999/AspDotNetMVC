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
        int BytesExported { get; }
        byte[] GetSequence(string source);
    }
}
