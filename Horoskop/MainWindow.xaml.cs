﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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


namespace Horoskop
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
        public string b;
       public void send_Click(object sender, RoutedEventArgs e)
        {
            // DateTime selectedDate = (DateTime)myDatePicker.SelectedDate;
            //var Datauro= DateTime selectedDate;

            DateTime selectedDate = (DateTime)myDatePicker.SelectedDate;
         UstalDatę a = new UstalDatę(selectedDate);
              b = Convert.ToString(a.GetSelectedDate());
            MessageBox.Show(b);
        }

    }
}
