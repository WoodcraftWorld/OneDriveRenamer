﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace OneDriveRenamer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("pname.bat");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Process.Start("prevert.bat");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Process.Start("bname.bat");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Process.Start("brevert.bat");
        }
    }
}
