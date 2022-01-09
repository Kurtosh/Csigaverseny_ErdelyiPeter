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

namespace Csigaverseny_ErdelyiPeter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer idozito;
        int poz1 = 0;
        int poz2 = 0;
        int poz3 = 0;
        public MainWindow()
        {
            InitializeComponent();
            ujFutamGomb.IsEnabled = false;
            idozito = new DispatcherTimer();
            idozito.Interval = TimeSpan.FromSeconds(0.1);
            idozito.Tick += new EventHandler(Mozgas);
        }

        private void Mozgas(object sender, EventArgs e)
        {
            Random rnd = new Random();
            poz1 += rnd.Next(30, 51);
            poz2 += rnd.Next(30, 51);
            poz3 += rnd.Next(30, 51);
            csiga1.Margin = new Thickness(poz1, 120, 0, 0);
            csiga2.Margin = new Thickness(poz2, 220, 0, 0);
            csiga3.Margin = new Thickness(poz3, 320, 0, 0);
            
        }

        private void startGomb_Click(object sender, RoutedEventArgs e)
        {
            idozito.Start();
        }
    }
}
