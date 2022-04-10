using Scanner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingScannerLibrary;

public class ToPDF : IScanOutputFormat
{
    public void ScanTo(IScanner scanner, string source, string destination)
    {
        var outArray = scanner.GetSequence(source);
        File.WriteAllBytes(destination + ".PDF", outArray);
    }
}
