using NisHakaton2018.DataModels;
using POSSystemNIS.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

namespace POSSystemNIS
{
    /// <summary>
    /// Interaction logic for Tablet.xaml
    /// </summary>
    public partial class Tablet : Window
    {
        public MainWindow main;
        public List<PredlozenoTablet> PredlozenoTablet
        {
            get { return dgTablet.ItemsSource as List<PredlozenoTablet>; }
            set { dgTablet.ItemsSource = value; }
        }

        public Tablet(MainWindow mainWindow)
        {
            InitializeComponent();
            main = mainWindow;

            
        }


        private BitmapImage BitmapToImageSource(Bitmap bitmap)
        {
            using (MemoryStream memory = new MemoryStream())
            {
                bitmap.Save(memory, System.Drawing.Imaging.ImageFormat.Bmp);
                memory.Position = 0;
                BitmapImage bitmapimage = new BitmapImage();
                bitmapimage.BeginInit();
                bitmapimage.StreamSource = memory;
                bitmapimage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapimage.EndInit();

                return bitmapimage;
            }
        }

        internal void SetList(List<Roba> predlozeniArtikli)
        {
            List<PredlozenoTablet> predlozeno = new List<PredlozenoTablet>();

            if (predlozeniArtikli != null)
            {
                foreach (var item in predlozeniArtikli.Take(4))
                {
                    var img = BitmapToImageSource(Properties.Resources.generic);

                    if(item.NazivRobe.Contains("COLA"))
                    {
                        img = BitmapToImageSource(Properties.Resources.kolakfaakcija);
                    }
                    if (item.NazivRobe.Contains("KIT"))
                    {
                        img = BitmapToImageSource(Properties.Resources.kolakitkatakcija);
                    }
                    if (item.NazivRobe.Contains("ROSA") || item.NazivRobe.Contains("K.MIL") || item.NazivRobe.Contains("AQ"))
                    {
                        img = BitmapToImageSource(Properties.Resources.kolavodaakcija);
                    }
                    if (item.NazivRobe.Contains("DC "))
                    {
                        img = BitmapToImageSource(Properties.Resources.kolakafazapon);
                    }

                    if (item.NazivRobe.Contains("ILLY"))
                    {
                        img = BitmapToImageSource(Properties.Resources.kolakfaakcija);
                    }
                    predlozeno.Add(new PredlozenoTablet { SifraRobe = item.SifraRobe, Image = img });
                }
            }
           
            dgTablet.ItemsSource = predlozeno;
        }

        private void dgTablet_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = dgTablet.SelectedItem as PredlozenoTablet;
            if(item != null)
            {
                var artial = main.ArtikliNaStanju.FirstOrDefault(o => o.SifraRobe == item.SifraRobe);

                if (artial == null) return;

                    var artikli = main.Transakcija ?? new List<Roba>();

                if (artikli.FirstOrDefault(o => o.SifraRobe == artial.SifraRobe) != null)
                {
                    artikli.FirstOrDefault(o => o.SifraRobe == artial.SifraRobe).Kolicina += 1;
                }
                else
                {
                    artial.Kolicina = 1;
                    artial.Rb = artikli.Count() + 1;
                    artikli.Add(artial);
                }

                main.Transakcija = artikli.OrderBy(o => o.Rb).ToList();

                main.txtCena.Text = "";
                main.txtUnos.Text = "";
                main.cbArtikliNaStanju.SelectedValue = null;
                main.cbArtikliNaStanju.Focus();
            }
        }
    }
}
