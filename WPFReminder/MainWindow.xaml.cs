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

namespace WPFReminder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            WPFReference.Service1Client client = new WPFReference.Service1Client();
            var x = client.GetAllSeries();
            var c = x;
        }

        DateTime reminderStart = Convert.ToDateTime("12:00:00");
        DateTime reminderStop = Convert.ToDateTime("12:02:00");
        public bool Reminder()
        {
            return (DateTime.Now > reminderStart && DateTime.Now < reminderStop);
        }
    }
}