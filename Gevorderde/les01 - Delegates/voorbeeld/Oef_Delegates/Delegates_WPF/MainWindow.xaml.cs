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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Delegates_WPF
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

       

        private void BtnPrint_Click(object sender, RoutedEventArgs e)
        {
            lblResultaat.Content = "";
            // Print delegate verwijst naar PrintAlsGetal
            Print printDel = new Print( PrintAlsGetal);
           
            lblResultaat.Content += printDel.Invoke(100000);
            lblResultaat.Content += printDel.Invoke(200);

            // Print delegate verwijst naar PrintAlsValuta
            printDel = PrintAlsValuta;   //alternatieve manier

            lblResultaat.Content += printDel(10000);   //alternatieve manier van Invoke
            lblResultaat.Content += printDel(200);
        }
                
        public string PrintAlsGetal(int getal)
        {
            return $"Getal: {getal}" + Environment.NewLine;
        }

        public string PrintAlsValuta(int bedrag)
        {
            return $"Valuta: {bedrag.ToString("c")}" + Environment.NewLine;
        }

        private void BtnDelegateAlsParameter_Click(object sender, RoutedEventArgs e)
        {
            lblResultaat.Content = PrinterHelper.PrintMethode(PrintAlsGetal, 5);
        }
    }
}
// lblResultaat.Content += PrinterHelper.PrintMethode(PrintAlsValuta, 15);