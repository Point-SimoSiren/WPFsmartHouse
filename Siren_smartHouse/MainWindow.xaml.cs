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

namespace Siren_smartHouse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Lights olohuone = new Lights();
        public Lights keittio = new Lights();
        public Sauna kiuas = new Sauna();
        public Thermostat housetemp = new Thermostat();
        public DispatcherTimer SaunaTimer = new System.Windows.Threading.DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            {

                txtSauna.Text = ("");

                lblLampotila.Content = "";

                SaunaTimer.Tick += SaunanLampo_Tick;
                SaunaTimer.Interval = new TimeSpan(0, 0, 1);
            }

        }

        private void SaunanLampo_Tick(object sender, EventArgs e)
        {
            kiuas.SaunaTemperature = kiuas.SaunaTemperature + 0.15;
            lblLampotila.Content = kiuas.SaunaTemperature.ToString();
        }
        private void btn_ohkirkas_Click(object sender, RoutedEventArgs e)
        {
            olohuone.Dim100();
            txtOh.Text = olohuone.Dimmer;
        }


        private void Btn_settarget_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Tahallaan aiheutettu virhe ekassa if haarassa testausharjoittelua varten
                //Voi korvata toisella haaralla ja poistaa kokonaan ensimmäisen.
                if ((int.Parse(txtTarget.Text) == 21))
                {   
                    housetemp.Temperature = 16;

                    txtHeat.Text = (housetemp.Temperature.ToString());
                    txtTarget.Text = null;
                }
                else if ((int.Parse(txtTarget.Text) > 4) && (int.Parse(txtTarget.Text) < 31))
                {
                    housetemp.Temperature = int.Parse(txtTarget.Text);

                    txtHeat.Text = (housetemp.Temperature.ToString());
                    txtTarget.Text = null;
                }
                else
                {
                    MessageBox.Show("Lämpötila-asetuksen tulee olla välillä 5-30");
                }
            }
            catch
            {
                MessageBox.Show("Syötä numeraalinen lämpötila-arvo");
            }

        }

        private void btn_ohpuoliv_Click(object sender, RoutedEventArgs e)
        {
            olohuone.Dim66();
            txtOh.Text = olohuone.Dimmer;
        }

        private void btn_ohhamara_Click(object sender, RoutedEventArgs e)
        {
            olohuone.Dim33();
            txtOh.Text = olohuone.Dimmer;
        }

        private void btn_ohpois_Click(object sender, RoutedEventArgs e)
        {
            olohuone.Dim00();
            txtOh.Text = olohuone.Dimmer;
        }

        private void btn_keitkirkas_Click(object sender, RoutedEventArgs e)
        {
            keittio.Dim100();
            txtKeit.Text = keittio.Dimmer;
        }

        private void btn_keitpuoliv_Click(object sender, RoutedEventArgs e)
        {
            keittio.Dim66();
            txtKeit.Text = keittio.Dimmer;
        }

        private void btn_keithamara_Click(object sender, RoutedEventArgs e)
        {
            keittio.Dim33();
            txtKeit.Text = keittio.Dimmer;
        }

        private void btn_keitpois_Click(object sender, RoutedEventArgs e)
        {
            keittio.Dim00();
            txtKeit.Text = keittio.Dimmer;
        }

        public void btn_kiuas_Click(object sender, RoutedEventArgs e)
        {
            if (kiuas.Switched)
            {
                kiuas.AsetaSauna(0);
                txtSauna.Text = "";
                SaunaTimer.Stop();
                lblLampotila.Content = "";
            }
            else
            {
                kiuas.AsetaSauna(1);
                txtSauna.Text = "Kiuas päällä";
                SaunaTimer.Start();


            }
        }


    }
}
    

        
    
    

