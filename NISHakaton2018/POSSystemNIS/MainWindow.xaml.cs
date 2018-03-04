using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using NisHakaton2018.DataModels;
using NisHakaton2018.Repository;

namespace POSSystemNIS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Properties
        public List<Roba> ArtikliNaStanju
        {
            get { return cbArtikliNaStanju.ItemsSource as List<Roba>; }
            set { cbArtikliNaStanju.ItemsSource = value; }
        }

        public List<VrstaBS> VrstaPumpe
        {
            get { return cbVrstaPumpe.ItemsSource as List<VrstaBS>; }
            set { cbVrstaPumpe.ItemsSource = value; }
        }

        public List<Roba> Transakcija
        {
            get { return dgTransakcija.ItemsSource as List<Roba>; }
            set { dgTransakcija.ItemsSource = value; }
        }

        public List<Roba> PredlozeniArtikli
        {
            get { return dgPredlozeniArtikli.ItemsSource as List<Roba>; }
            set { dgPredlozeniArtikli.ItemsSource = value; }
        }

        public Roba SelectedArtikal
        {
            get;
            set;
        }

        public VrstaBS SelectedPumpa
        {
            get;
            set;
        }

        public Tablet TabletWindow { get; set; }

        #endregion

        public MainWindow()
        {
            InitializeComponent();
            //123

            var artikli = new List<Roba>
            {
                new Roba
                {
                    SifraRobe = "1",
                    NazivRobe = "Naziv",
                    GrupaRobe = "Grupa",
                    VrstaRobe = "Vrsta",
                    Cena = 10
                }
            };

            var pumpe = new List<VrstaBS>
            {
                new VrstaBS{SifraBS = "1",Naziv= "Naziv"}
            };

            Transakcija = PredlozeniArtikli = ArtikliNaStanju = artikli;
            VrstaPumpe = pumpe;
            
            //using (var context = new DBContex())
            //{
            //    roba = context.Roba.ToList();
            //}
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            if (TabletWindow == null)
            {
                TabletWindow = new Tablet();
                TabletWindow.Show();
            }
        }
    }
}
