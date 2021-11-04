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

namespace Kassa
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
            txtAantal.Text = "";
            txtPrijs.Text = "";
            lblResultaat.Content = "";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(txtPrijs.Text, out double prijs))
            {
                if (double.TryParse(txtAantal.Text, out double aantal))
                {
                    double resultaat = aantal * prijs;
                    lblResultaat.Content = $"{resultaat.ToString("0.00")}€";
                }
                else
                {
                    lblResultaat.Content = "Prijs heeft geen numerieke waarde ";
                }

            }
            else
            {
                lblResultaat.Content = "Aantal heeft geen numerieke waarde ";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            App.Current.MainWindow.Close();
        }
    }
}
