using System;
using System.Windows;
using System.Threading;
using System.Windows.Threading;

namespace WPFMultiThread
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool interruptToken = false;
        public MainWindow()
        {
            InitializeComponent();

            Thread fibThread = new(FibonacciNumberAdd);
            
            fibThread.Start();

        }


        private void FibonacciNumberAdd()
        {
            int a = 0;
            int b = 1;
            while (!interruptToken)
            {
                string tmpStr = FibonacciCalculate(ref a, ref b).ToString();
                textBlock.Dispatcher.BeginInvoke(DispatcherPriority.Background , new Action(() =>
                {
                    textBlock.Inlines.Add(tmpStr + "\n");
                }));
            }
        }

        private int FibonacciCalculate(ref int a, ref int b)
        {
            int currentFibNumber = a + b;
            a = b;
            b = currentFibNumber;
            return currentFibNumber;
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            interruptToken = true;
        }
    }
}
