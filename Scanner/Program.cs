using Scanner;

var scanner = ScannerEmulator.GetInstace();

byte[] arr = scanner.GetSequence("Scanner.pdb");

foreach (var item in arr)
{
    Console.Write(Convert.ToChar(item));
}

