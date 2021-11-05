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
       

        private void BtnDelegatesIntro_Click(object sender, RoutedEventArgs e)
        {
            DelegatesIntro delegatesIntro = new DelegatesIntro();
            delegatesIntro.Show();
        }

        private void BtnDelegatesInAction_Click(object sender, RoutedEventArgs e)
        {
            DelegatesInAction delegatesInAction = new DelegatesInAction();
            delegatesInAction.Show();
        }


    }
}
