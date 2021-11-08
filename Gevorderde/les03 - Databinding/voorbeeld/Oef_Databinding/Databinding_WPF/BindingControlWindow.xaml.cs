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
    /// Interaction logic for BindingNaarControl.xaml
    /// </summary>
    public partial class BindingControlWindow : Window
    {
        public BindingControlWindow()
        {
            InitializeComponent();
        }

        //private void SliderGrootte_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        //{
        //    if (sliderGrootte != null && lblWaarde!= null && txtWaarde!= null)
        //    {
        //        txtWaarde.Text = sliderGrootte.Value.ToString();
        //        lblWaarde.FontSize = sliderGrootte.Value;
        //    }
        //}
    }
}
