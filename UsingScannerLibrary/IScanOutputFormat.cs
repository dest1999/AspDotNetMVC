using Scanner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingScannerLibrary
{
    public interface IScanOutputFormat
    {
        void ScanTo(IScanner scanner, string destination);
    }
}
