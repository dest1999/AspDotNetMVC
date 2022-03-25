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
        private int numbersInSecond = 0;
        public MainWindow()
        {
            InitializeComponent();

            Thread fibThread = new(FibonacciNumberAddToTextBlock);
            
            fibThread.Start();
        }


        private void FibonacciNumberAddToTextBlock()
        {
            ulong a = 0;
            ulong b = 1;
            string tmpStr;

            while (!interruptToken)
            {
                if(numbersInSecond > 0)
                {
                    Thread.Sleep(1000 / numbersInSecond);
                    tmpStr = FibonacciCalculate(ref a, ref b).ToString();
                    if (string.IsNullOrEmpty(tmpStr))
                    {
                        interruptToken = true;
                        break;
                    }
                    textBlock.Dispatcher.BeginInvoke(DispatcherPriority.Background , new Action(() =>
                    {
                        textBlock.Inlines.Add(tmpStr + "\n");
                    }));
                }
                else
                {
                    Thread.Sleep(500);
                }
            }
        }

        private ulong? FibonacciCalculate(ref ulong a, ref ulong b)
        {
            ulong currentFibNumber = a + b;
            a = b;
            if (currentFibNumber < b)
            {
                return null;
            }
            b = currentFibNumber;
            return currentFibNumber;
        }

        private void OnWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {//прекращаем поток при закрытии окна
            interruptToken = true;
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {//слайдер задержки, при значении 0 не вычисляем
            numbersInSecond = (int)slider.Value;
        }
    }
}
