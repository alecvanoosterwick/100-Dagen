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

namespace Werknemer
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

        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            string foutmelding = "";

            if (string.IsNullOrEmpty(txtAnaam.Text))
            {
                foutmelding = "Achternaam moet ingevoerd worden";
            }
            if (string.IsNullOrEmpty(txtVnaam.Text))
            {
                foutmelding = "Voornaam moet ingevoerd worden";
            }
            if (!double.TryParse(txtVerdienst.Text, out double verdienst))
            {
                foutmelding = "Verdiensten moet een numerieke waarden hebben";
            }
            if (string.IsNullOrEmpty(foutmelding))
            {
                lblResultaat.Text = txtAnaam.Text
            }
        }
    }
}
