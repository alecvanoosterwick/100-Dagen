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

namespace Cirkel
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

        private void btnBereken_Click(object sender, RoutedEventArgs e)
        {

            if (double.TryParse(txtStraal.Text, out double straal))
            {
                double omtrek = Math.PI * (straal + straal);
                double oppervlakte = straal * straal * Math.PI;

                lblResultaat.Content = $"Omtrek : {omtrek.ToString("0.00")} \nOppervlakte : {oppervlakte.ToString("0.00")}";
            }
            else
            {
                lblResultaat.Content = "Straal moet een numerieke waarde zijn";
            }
            
        }

    }
}
