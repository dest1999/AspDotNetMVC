﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ICommandPattern
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            RunMethod();
        }

        private void RunMethod()
        {
            Storage.Add(CommandFirstClass.Create());
            Storage.Add(CommandSecondClass.Create());
            Storage.Add(CommandFirstClass.Create());
            Storage.Add(CommandSecondClass.Create());
            Storage.Add(CommandFirstClass.Create());
            Storage.Add(CommandSecondClass.Create());
            Storage.Add(CommandFirstClass.Create());
            Storage.Add(CommandSecondClass.Create());
            Storage.GetById(1).Execute("signal string");
            Storage.GetById(5).Execute("signal string");

        }

    }
}
