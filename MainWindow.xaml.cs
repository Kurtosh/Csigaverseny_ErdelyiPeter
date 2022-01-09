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
        int poz1 = new int();
        int poz2 = new int();
        int poz3 = new int();
        public MainWindow()
        {
            InitializeComponent();
            ujFutamGomb.IsEnabled = false;
            idozito = new DispatcherTimer();
            idozito.Interval = TimeSpan.FromSeconds(1);
            idozito.Tick += new EventHandler(Mozgas);
        }

        private void Mozgas(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void startGomb_Click(object sender, RoutedEventArgs e)
        {
            idozito.Start();
        }
    }
}
