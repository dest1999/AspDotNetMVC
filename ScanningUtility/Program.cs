// See https://aka.ms/new-console-template for more information


using Scanner;
using UsingScannerLibrary;

var scanWorker = new ScannerWorkingClass(ScannerEmulator.GetInstace());

scanWorker.OutputMethodSelector(new ToBMP());

scanWorker.Scan(@"C:\tcc\LCS.c", @"C:\tcc\!LCS");


Console.WriteLine("Hello, World!");
