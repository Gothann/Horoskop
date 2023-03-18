using System;
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
        
        private void send_Click(object sender, RoutedEventArgs e)
        {
            // DateTime selectedDate = (DateTime)myDatePicker.SelectedDate;
            //var Datauro= DateTime selectedDate;

            DateTime selectedDate = (DateTime)myDatePicker.SelectedDate;
         UstalZodiak a = new UstalZodiak(selectedDate);
            MessageBox.Show(a.GetSelectedDate);
        }

    }
}
