using Scanner;

namespace UsingScannerLibrary;

public class ScannerWorkingClass
{
    private IScanner scanner;
    private IScanOutputFormat outputFormat;

    public ScannerWorkingClass(IScanner Scanner)
    {
        scanner = Scanner;
    }

    public void OutputMethodSelector(IScanOutputFormat scanOutput)
    {
        outputFormat = scanOutput;
    }

    public void Scan(string source, string output)
    {
        if (string.IsNullOrWhiteSpace(output))
        {
            throw new ArgumentException("output not selected");
        }

        outputFormat.ScanTo(scanner, source, output);
    }
}
