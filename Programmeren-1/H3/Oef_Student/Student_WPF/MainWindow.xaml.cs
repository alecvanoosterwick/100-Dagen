using Student_Models;
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

namespace Student_WPF
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

        private void btnTonen_Click(object sender, RoutedEventArgs e)
        {
           
            if (int.TryParse(txtWiskunde.Text, out int pntWiskunde) && int.TryParse(txtInformatica.Text, out int pntInfo))
            {
                Student mijnstudent = new Student();
                mijnstudent.Naam = txtNaam.Text;
                mijnstudent.Wiskunde = pntWiskunde;
                mijnstudent.Informatica = pntInfo;
                lblResultaat.Content = mijnstudent.ToonGegevens();
            }
            else
            {
                MessageBox.Show("Geef numerieke waarde in!", "Foutmelding", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
