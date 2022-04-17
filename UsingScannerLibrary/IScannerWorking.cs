using Scanner;

namespace UsingScannerLibrary
{
    public interface IScannerWorking
    {
        void OutputMethodSelector(IScanOutputFormat scanOutput);
        void Scan(string source, string output);
        void SelectScannerDevice(IScanner scanner);
    }
}