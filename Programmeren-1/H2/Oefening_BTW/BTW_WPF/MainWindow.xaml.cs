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

namespace BTW_WPF
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

        private void btnAfsluiten_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void btnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            double resultaat = 0;

            if (double.TryParse(txtBedrag.Text, out double bedrag))
            {
                 if (rb6.IsChecked == true)
                {
                    resultaat = bedrag *1.06;
                }
                else if (rb12.IsChecked == true)
                {
                    resultaat = bedrag * 1.12;
                }
                else if (rb21.IsChecked == true)
                {
                    resultaat = bedrag * 1.21;
                }
                else
                {
                    resultaat = bedrag;
                }
            }
            else
            {
                MessageBox.Show("Bedrag moet een getal zijn");
            }
            txtBtw.Text = resultaat.ToString("0.00");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            rb21.IsChecked = true;
            txtBtw.IsEnabled = false;
        }
    }
}
