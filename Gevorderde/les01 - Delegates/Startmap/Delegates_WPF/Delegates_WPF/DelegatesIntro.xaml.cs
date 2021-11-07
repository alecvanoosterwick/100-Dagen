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
        Winkelkar winkelkar = new Winkelkar();
        Printer printer = new Printer();
        KortingBerekenaar kortingBerekenaar = new KortingBerekenaar();


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product() { Code = 1, Omschrijving = "T-shirt", Prijs = 1.0m });
            products.Add(new Product() { Code = 2, Omschrijving = "T-shirt", Prijs = 2.0m });
            products.Add(new Product() { Code = 3, Omschrijving = "T-shirt", Prijs = 3.0m });

            cmbProducten.ItemsSource = products;
            lstWinkelkar.ItemsSource = winkelkar.WinkelkarItems;
        }
        private void Kopen_click(object sender, RoutedEventArgs e)
        {
            string foutmelding = Valideer("txtAantal");
            foutmelding += Valideer("cmbProducten");

            if (string.IsNullOrWhiteSpace(foutmelding))
            {
                WinkelkarItem winkelkaritem = new WinkelkarItem() { Aantal = int.Parse(txtAantal.Text), Product = cmbProducten.SelectedItem as Product };
                winkelkar.VoegWinkelkarItemToe(winkelkaritem);
                lstWinkelkar.Items.Refresh();
            }
            else
            {
                MessageBox.Show(foutmelding);
            }
        }


        private string Valideer(string iets)
        {
            string foutmelding = "";
            if (iets == "txtAantal" && !int.TryParse(txtAantal.Text, out int aanntal))
            {
                foutmelding = "aantal moet een numerieke waarde hebben";
            }
            if (iets == "cmbProducten" && cmbProducten.SelectedItem == null)
            {
                foutmelding += "Er moet een product geselecteerd zijn";
            }
            return foutmelding;
        }
        private void Afdrukken1_Click(object sender, RoutedEventArgs e)
        {
            PrintHandler PrintDc = new PrintHandler(printer.PrintMethod1);
            txtBon1.Text = PrintDc.Invoke(winkelkar);

            decimal totaal = winkelkar.Totaal();
            decimal korting = winkelkar.Korting(kortingBerekenaar.Korting1);

            txtBon1.Text += printer.TotaalAfdrukken(totaal, korting);
        }
        private void Afdrukken2_Click(object sender, RoutedEventArgs e)
        {
            PrintHandler PrintDc = new PrintHandler(printer.PrintMethod2);
            txtBon2.Text = PrintDc.Invoke(winkelkar);

            decimal totaal = winkelkar.Totaal();
            decimal korting = winkelkar.Korting(kortingBerekenaar.Korting2);

            txtBon2.Text += printer.TotaalAfdrukken(totaal, korting);


        }
    }
}
