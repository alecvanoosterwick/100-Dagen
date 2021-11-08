using Databinding_DAL;
using Databinding_WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for BindingNaarObjectVoorbeeld1.xaml
    /// </summary>
    public partial class BindingNaarCollectionWindow : Window
    {
        public BindingNaarCollectionWindow()
        {
            InitializeComponent();
        }

        BindingNaarCollectionViewModel vm = new BindingNaarCollectionViewModel();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = vm;
        }

        private void BtnZoeken_Click(object sender, RoutedEventArgs e)
        {
            vm.Zoeken();    
        }

        private void BtnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            vm.Verwijderen();
        }
    }
}
