using Delegates_Models;
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
using System.Windows.Shapes;

namespace Delegates_WPF
{
    /// <summary>
    /// Interaction logic for DelegatesIntro.xaml
    /// </summary>
    public partial class DelegatesIntro : Window
    {
        public DelegatesIntro()
        {
            InitializeComponent();
        }
        Winkelkar winkelekar = new Winkelkar();
        Printer printer = new Printer();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           List<Product> product = new List<Product>();

            product.Add(new Product() { Code = 1, Omschrijving = "T-shirt", Prijs = 1.0m});
            product.Add(new Product() { Code = 2, Omschrijving = "T-shirt", Prijs = 2.0m });
            product.Add(new Product() { Code = 3, Omschrijving = "T-shirt", Prijs = 3.0m });
            product.Add(new Product() { Code = 4, Omschrijving = "T-shirt", Prijs = 4.0m });
            product.Add(new Product() { Code = 5, Omschrijving = "T-shirt", Prijs = 5.0m });

            cmbProducten.ItemsSource = product;

            lstWinkelkar.ItemsSource = winkelekar.WinkelkarItems;
        }
        private void BtnAfdrukken1_Click(object sender, RoutedEventArgs e)
        {
            PrintHandler print = new PrintHandler(printer.PrintMethod1);

            txtBon1.Text = print.Invoke(winkelekar);
        }
    }
}
