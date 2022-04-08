using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ICommandPattern
{
    internal class CommandFirstClass : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public static ICommand Create()
        {
            return new CommandFirstClass();
        }

        public void Execute(object? parameter)
        {
            MessageBox.Show("First class",  $"{parameter}");
        }
    }
}
