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
using Teller_Models;

namespace Teller_WPF
{
    public partial class MainWindow : Window
    {
        Teller teller = new Teller();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSluit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnWeergeven_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(teller.ToonGegevens(), "Waarde Teller");
        }

        private void btnVerhoog_Click(object sender, RoutedEventArgs e)
        {
            teller.Verhoog();
        }

        private void btnVerlaag_Click(object sender, RoutedEventArgs e)
        {
            teller.Verlagen();
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            teller.Resetten();
        }
    }
}
