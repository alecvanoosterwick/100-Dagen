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

namespace Databinding_WPF
{
    /// <summary>
    /// Interaction logic for BidningNaarObjectVoorbeeld2.xaml
    /// </summary>
    public partial class BindingNaarObjectWindow : Window
    {
        public BindingNaarObjectWindow()
        {
            InitializeComponent();
        }

        ViewModels.BindingNaarObjectViewModel vm = new ViewModels.BindingNaarObjectViewModel();


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = vm;
        }

        private void BtnZoeken_Click(object sender, RoutedEventArgs e)
        {
            vm.Zoeken();
        }


        private void BtnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            vm.Toevoegen();
        }




        private void BtnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            vm.Verwijderen();
        }



        private void BtnAanpassen_Click(object sender, RoutedEventArgs e)
        {
            vm.Aanpassen();
        }



        private void BtnAnnuleren_Click(object sender, RoutedEventArgs e)
        {
            vm.Resetten();
        }


    }
}
