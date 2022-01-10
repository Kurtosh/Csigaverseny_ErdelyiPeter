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
        int[] helyezesek = new int[10];
        public MainWindow()
        {
            InitializeComponent();
            ujFutamGomb.IsEnabled = false;
            ujBajnoksagGomb.IsEnabled = false;
            bajnoksagMegjelenitese.IsEnabled = false;
            idozito = new DispatcherTimer();
            idozito.Interval = TimeSpan.FromSeconds(1);
            idozito.Tick += new EventHandler(Mozgas);
            elsoVonal.Fill = Brushes.Gray;
            masodikVonal.Fill = Brushes.Gray;
            harmadikVonal.Fill = Brushes.Gray;
            for (int i = 0; i < helyezesek.Length; i++)
            {
                helyezesek[i] = 0;
            }
        }

        private void Mozgas(object sender, EventArgs e)
        {
            Random rnd = new Random();
                poz1 += rnd.Next(20, 301);
                csiga1.Margin = new Thickness(poz1, 120, 0, 0);
            if (poz1 > 680)
            {
                csiga1.Margin = new Thickness(680, 120, 0, 0);
            }
                poz2 += rnd.Next(20, 301);
                csiga2.Margin = new Thickness(poz2, 220, 0, 0);
            if (poz2 > 680)
            {
                csiga2.Margin = new Thickness(680, 220, 0, 0);
            }
                poz3 += rnd.Next(20, 301);
                csiga3.Margin = new Thickness(poz3, 320, 0, 0);
            if (poz3 > 680)
            {
                csiga3.Margin = new Thickness(680, 320, 0, 0);
            }
            if (csiga1.Margin == new Thickness(680, 120, 0, 0) && csiga2.Margin == new Thickness(680, 220, 0, 0) && csiga3.Margin == new Thickness(680, 320, 0, 0))
            {
                idozito.Stop();
                ujFutamGomb.IsEnabled = true;
                poz1 = 0;
                poz2 = 0;
                poz3 = 0;
                if (elsoVonal.Fill == Brushes.Yellow)
                {
                    helyezesek[1]++;
                }
                else
                {
                    if (elsoVonal.Fill == Brushes.Silver)
                    {
                        helyezesek[2]++;
                    }
                    else
                    {
                            helyezesek[3]++;
                    }
                }
                if (masodikVonal.Fill == Brushes.Yellow)
                {
                    helyezesek[4]++;
                }
                else
                {
                    if (masodikVonal.Fill == Brushes.Silver)
                    {
                        helyezesek[5]++;
                    }
                    else
                    {
                            helyezesek[6]++;
                    }
                }
                if (harmadikVonal.Fill == Brushes.Yellow)
                {
                    helyezesek[7]++;
                }
                else
                {
                    if (harmadikVonal.Fill == Brushes.Silver)
                    {
                        helyezesek[8]++;
                    }
                    else
                    {
                            helyezesek[9]++;
                    }
                }
            }
            if (csiga1.Margin == new Thickness(680, 120, 0, 0) && csiga2.Margin != new Thickness(680, 220, 0, 0) && csiga3.Margin != new Thickness(680, 320, 0, 0))
            {
                elsoVonal.Fill = Brushes.Yellow;
            }
            else
            {
                if ((masodikVonal.Fill == Brushes.Yellow && csiga1.Margin == new Thickness(680, 120, 0, 0)) || (harmadikVonal.Fill == Brushes.Yellow && csiga1.Margin == new Thickness(680, 120, 0, 0)))
                {
                    elsoVonal.Fill = Brushes.Silver;
                }
                    if ((masodikVonal.Fill == Brushes.Yellow && harmadikVonal.Fill == Brushes.Silver && csiga1.Margin == new Thickness(680, 120, 0, 0)) || (harmadikVonal.Fill == Brushes.Yellow && masodikVonal.Fill == Brushes.Silver && csiga1.Margin == new Thickness(680, 120, 0, 0)))
                    {
                        elsoVonal.Fill = Brushes.Brown;
                    }
            }
            if (csiga2.Margin == new Thickness(680, 220, 0, 0) && csiga1.Margin != new Thickness(680, 120, 0, 0) && csiga3.Margin != new Thickness(680, 320, 0, 0))
            {
                masodikVonal.Fill = Brushes.Yellow;
            }
            else
            {
                if ((elsoVonal.Fill == Brushes.Yellow && csiga2.Margin == new Thickness(680, 220, 0, 0)) || (harmadikVonal.Fill == Brushes.Yellow && csiga2.Margin == new Thickness(680, 220, 0, 0)))
                {
                    masodikVonal.Fill = Brushes.Silver;
                }
                if ((elsoVonal.Fill == Brushes.Yellow && harmadikVonal.Fill == Brushes.Silver && csiga2.Margin == new Thickness(680, 220, 0, 0)) || (harmadikVonal.Fill == Brushes.Yellow && elsoVonal.Fill == Brushes.Silver && csiga2.Margin == new Thickness(680, 220, 0, 0)))
                {
                    masodikVonal.Fill = Brushes.Brown;
                }
            }
            if (csiga3.Margin == new Thickness(680, 320, 0, 0) && csiga2.Margin != new Thickness(680, 220, 0, 0) && csiga1.Margin != new Thickness(680, 120, 0, 0))
            {
                harmadikVonal.Fill = Brushes.Yellow;
            }
            else
            {
                if ((masodikVonal.Fill == Brushes.Yellow && csiga3.Margin == new Thickness(680, 320, 0, 0)) || (elsoVonal.Fill == Brushes.Yellow && csiga3.Margin == new Thickness(680, 320, 0, 0)))
                {
                    harmadikVonal.Fill = Brushes.Silver;
                }
                if ((masodikVonal.Fill == Brushes.Yellow && elsoVonal.Fill == Brushes.Silver && csiga3.Margin == new Thickness(680, 320, 0, 0)) || (elsoVonal.Fill == Brushes.Yellow && masodikVonal.Fill == Brushes.Silver && csiga3.Margin == new Thickness(680, 320, 0, 0)))
                {
                    harmadikVonal.Fill = Brushes.Brown;
                }
            }
            if (elsoVonal.Fill == Brushes.Gray && masodikVonal.Fill == Brushes.Gray && harmadikVonal.Fill == Brushes.Gray && csiga1.Margin == new Thickness(680, 120, 0, 0) && csiga2.Margin == new Thickness(680, 220, 0, 0) && csiga3.Margin == new Thickness(680, 320, 0, 0))
            {
                MessageBox.Show("Döntetlen történt. A futam érvénytelen.");
            }

        }

        private void startGomb_Click(object sender, RoutedEventArgs e)
        {
            idozito.Start();
            startGomb.IsEnabled = false;
            ujFutamGomb.IsEnabled = false;
            ujBajnoksagGomb.IsEnabled = false;
            bajnoksagMegjelenitese.IsEnabled = false;
        }

        private void ujFutamGomb_Click(object sender, RoutedEventArgs e)
        {
            csiga1.Margin = new Thickness(12, 120, 0, 0);
            csiga2.Margin = new Thickness(12, 220, 0, 0);
            csiga3.Margin = new Thickness(12, 320, 0, 0);
            ujFutamGomb.IsEnabled = false;
            startGomb.IsEnabled = true;
            ujBajnoksagGomb.IsEnabled = true;
            bajnoksagMegjelenitese.IsEnabled = true;
            elsoVonal.Fill = Brushes.Gray;
            masodikVonal.Fill = Brushes.Gray;
            harmadikVonal.Fill = Brushes.Gray;
        }

        private void bajnoksagMegjelenitese_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Csiga1: {helyezesek[1]} db 1. helyezés, {helyezesek[2]} db 2. helyezés és {helyezesek[3]} db 3. helyezés. Összesen {helyezesek[1] * 3 + helyezesek[2] * 2 + helyezesek[3]} pontja van." + "\n" + $"Csiga2: {helyezesek[4]} db 1. helyezés, {helyezesek[5]} db 2. helyezés és {helyezesek[6]} db 3. helyezés. Összesen {helyezesek[4] * 3 + helyezesek[5] * 2 + helyezesek[6]} pontja van." + "\n" + $"Csiga3: {helyezesek[7]} db 1. helyezés, {helyezesek[8]} db 2. helyezés és {helyezesek[9]} db 3. helyezés. Összesen {helyezesek[7] * 3 + helyezesek[8] * 2 + helyezesek[9]} pontja van.");
        }

        private void ujBajnoksagGomb_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Az előző bajnokság eredménye:" + "\n" + $"Csiga1: {helyezesek[1]} db 1. helyezés, {helyezesek[2]} db 2. helyezés és {helyezesek[3]} db 3. helyezés. Összesen {helyezesek[1] * 3 + helyezesek[2] * 2 + helyezesek[3]} pontja van." + "\n" + $"Csiga2: {helyezesek[4]} db 1. helyezés, {helyezesek[5]} db 2. helyezés és {helyezesek[6]} db 3. helyezés. Összesen {helyezesek[4] * 3 + helyezesek[5] * 2 + helyezesek[6]} pontja van." + "\n" + $"Csiga3: {helyezesek[7]} db 1. helyezés, {helyezesek[8]} db 2. helyezés és {helyezesek[9]} db 3. helyezés. Összesen {helyezesek[7] * 3 + helyezesek[8] * 2 + helyezesek[9]} pontja van.");
            for (int i = 0; i < helyezesek.Length; i++)
            {
                helyezesek[i] = 0;
            }
            ujBajnoksagGomb.IsEnabled = false;
            bajnoksagMegjelenitese.IsEnabled = false;
        }
    }
}
