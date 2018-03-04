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
        public List<PredlozenoTablet> PredlozenoTablet
        {
            get { return dgTablet.ItemsSource as List<PredlozenoTablet>; }
            set { dgTablet.ItemsSource = value; }
        }

        public Tablet()
        {
            InitializeComponent();

            List<PredlozenoTablet> predlozeno = new List<PredlozenoTablet>
            {
                new PredlozenoTablet{SifraRobe="1",Image= BitmapToImageSource(Properties.Resources.kolakfaakcija)},
                new PredlozenoTablet{SifraRobe="1",Image= BitmapToImageSource(Properties.Resources.kolakfaakcija)},
                 new PredlozenoTablet{SifraRobe="1",Image= BitmapToImageSource(Properties.Resources.kolakfaakcija)},
                  new PredlozenoTablet{SifraRobe="1",Image= BitmapToImageSource(Properties.Resources.kolakfaakcija)},
            };
            dgTablet.ItemsSource = predlozeno;
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
    }
}
