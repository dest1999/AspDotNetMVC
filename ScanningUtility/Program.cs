using Autofac;
using Scanner;
using UsingScannerLibrary;

var scanWorker = new ScannerWorkingClass(ScannerEmulator.GetInstace());

scanWorker.OutputMethodSelector(new ToBMP());

scanWorker.Scan(@"C:\tcc\LCS.c", @"C:\tcc\!LCS");

#region Autofac
var builder = new ContainerBuilder();
builder.RegisterType<ScannerWorkingClass>().As<IScannerWorking>();

IContainer container = builder.Build();

IScannerWorking scannerWorking = container.Resolve<IScannerWorking>();

scannerWorking.SelectScannerDevice(ScannerEmulator.GetInstace());

scannerWorking.OutputMethodSelector(new ToPDF());
scannerWorking.Scan(@"C:\tcc\LCS.c", @"C:\tcc\!LCS");
#endregion

Console.WriteLine("Hello, World!");
