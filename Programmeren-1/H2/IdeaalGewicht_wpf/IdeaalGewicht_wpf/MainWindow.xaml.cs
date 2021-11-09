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

namespace IdeaalGewicht_wpf
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

        private void BtnSluiten_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void BtnBerekenen_Click(object sender, RoutedEventArgs e)
        {
            double ideaalGewicht;

            if (double.TryParse(txtLengte.Text, out double Lengte))
            {
                if (rbMan.IsChecked == true)
                {
                    ideaalGewicht = 0.9 * (Lengte - 100);
                    txtGewicht.Text = ideaalGewicht.ToString("0.00");
                }
                else
                {
                    if (double.TryParse(txtOmtrek.Text, out double Omtrek))
                    {
                        ideaalGewicht = (Lengte + (4 * Omtrek) -100) / 2;
                        txtGewicht.Text = ideaalGewicht.ToString("0.00");
                    }
                    else
                    {
                        MessageBox.Show("breedte moet een numerieke waarde zijn");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lengte moet numeriek zijn");
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            rbMan.IsChecked = true;
            txtGewicht.IsEnabled = false;
        }

        private void rbMan_Checked(object sender, RoutedEventArgs e)
        {
            txtOmtrek.IsEnabled = false;
        }

        private void rbVrouw_Checked(object sender, RoutedEventArgs e)
        {
            txtOmtrek.IsEnabled = true;
        }
    }
}
