using Events_Models;
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

namespace Events_WPF
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

        Verbruiksmeter verbruiksmeter = new Verbruiksmeter();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // verbruiksmeter.TeHoogVerbruikEvent += new VerbruikHandler(Verbruiksmeter_TeHoogVerbruikEvent);
            verbruiksmeter.TeHoogVerbruikEvent += Verbruiksmeter_TeHoogVerbruikEvent;
           
        }

        private void Verbruiksmeter_TeHoogVerbruikEvent(int stand)
        {
            MessageBox.Show("Je zit met een te hoog verbruik: " + stand.ToString());
        }

      

        private void BtnEvent_Click(object sender, RoutedEventArgs e)
        {
            int verbruik = 0;
            if (int.TryParse(txtVerbruik.Text, out verbruik))
            {
                verbruiksmeter.AddVerbruik(verbruik);
                lblResult.Content = "Meterstand: " + verbruiksmeter.Meterstand.ToString();
            }
        }
    }
        
}
