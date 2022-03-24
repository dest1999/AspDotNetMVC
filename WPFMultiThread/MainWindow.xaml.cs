using System;
using System.Windows;
using System.Threading;
using System.Windows.Threading;

namespace WPFMultiThread
{
    /*
    Павел, возник вопрос: вроде всё работает, но очень быстро выедает память, серьёзная нагрузка на проц, ГУИ подтормаживает.
    При закрытии приложения поток вычислений выгружается не сразу, а через некоторое время.
    Что можно сделать для улучшения?
    Вышеописаное отсутствует при ограничении скорости потока (после внедрения слайдера)
    */
    public partial class MainWindow : Window
    {
        private bool interruptToken = false;
        private int timeout = 0;
        public MainWindow()
        {
            InitializeComponent();

            Thread fibThread = new(FibonacciNumberAddToTextBlock);
            
            fibThread.Start();
        }


        private void FibonacciNumberAddToTextBlock()
        {
            int a = 0;
            int b = 1;
            while (!interruptToken)
            {
                if(timeout > 0)
                {
                    Thread.Sleep(timeout * 1000);
                    string tmpStr = FibonacciCalculate(ref a, ref b).ToString();
                    textBlock.Dispatcher.BeginInvoke(DispatcherPriority.Background , new Action(() =>
                    {
                        textBlock.Inlines.Add(tmpStr + "\n");
                    }));
                }
                else
                {
                    Thread.Sleep(100);
                }
            }
        }

        private int FibonacciCalculate(ref int a, ref int b)
        {
            int currentFibNumber = a + b;
            a = b;
            b = currentFibNumber;
            return currentFibNumber;
        }

        private void OnWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {//прекращаем поток при закрытии окна
            interruptToken = true;
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {//слайдер задержки, при значении 0 не вычисляем
            timeout = (int)slider.Value;
        }
    }
}
