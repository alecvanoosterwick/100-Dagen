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
using System.Windows.Threading;

namespace Voertuig
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
        Voertuig voertuig = null;
        DispatcherTimer timer = new DispatcherTimer();

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer.Interval = new TimeSpan(0, 0, 1);

            voertuig = new Voertuig() { LitersInTank = 40 };
            voertuig.AutoGestartEvent += Voertuig_AutoGestartEvent;
            voertuig.AutoGestoptEvent += Voertuig_AutoGestoptEvent;
            voertuig.TankBijnaOpEvent += Voertuig_TankBijnaOpEvent;
            voertuig.TankChangeEvent += Voertuig_TankChangeEvent;
            voertuig.TankOpEvent += Voertuig_TankOpEvent;

            voertuig.Snelheid = 30;
            timer.Tick += Timer_Tick;

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            voertuig.VerminderAantalLiters();
        }

        private void Voertuig_TankOpEvent(Voertuig sender)
        {
            this.Background = Brushes.Red;
            MessageBox.Show("tank is op");
        }

        private void Voertuig_TankChangeEvent(Voertuig sender)
        {
            lblVoertuig.Content = voertuig.ToString();
        }

        private void Voertuig_TankBijnaOpEvent(Voertuig sender)
        {
            this.Background = Brushes.Orange;
            MessageBox.Show("tank is bijna op");
        }

        private void Voertuig_AutoGestoptEvent(Voertuig sender)
        {
            timer.Stop();
        }

        private void Voertuig_AutoGestartEvent(Voertuig sender)
        {
            timer.Start();
        }


    }
}
