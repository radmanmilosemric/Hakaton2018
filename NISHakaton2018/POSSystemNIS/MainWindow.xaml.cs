﻿using System;
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
using POSSystemNIS.Models;

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

        public List<PairedItem> PairedItems { get; set; }
        public List<KupacProizvod> KupacProizvodList { get; set; }
        public Tablet TabletWindow { get; set; }

        #endregion

        public MainWindow()
        {
            InitializeComponent();

            try
            {
                using (var context = new DBContex())
                {
                    ArtikliNaStanju = context.Roba.ToList();
                    VrstaPumpe = context.VrstaBS.ToList();
                    PairedItems = context.PairedItems.ToList();
                    KupacProizvodList = context.KupacProizvodList.ToList();
                }
            }
            catch (Exception ex)
            { 
                System.Windows.MessageBox.Show(ex.GetBaseException().ToString());
                throw;
            }
        }

        private void btnSet_Click(object sender, RoutedEventArgs e)
        {
            if (TabletWindow == null)
            {
                TabletWindow = new Tablet();
                TabletWindow.Show();
            }
        }

        private void cbArtikliNaStanju_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var izabran = cbArtikliNaStanju.SelectedValue as Roba;

            //if(izabran != null)
            //{
            //    SelectedArtikal = izabran;
            //    txtCena.Text = izabran.Cena.ToString("n2");
            //    txtUnos.Text = izabran.Cena.ToString("n2");
            //    txtUnos.Focus();
            //}
        }

        private void txtUnos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (SelectedArtikal != null)
                {
                    var artikli = Transakcija ?? new List<Roba>();

                    if (artikli.FirstOrDefault(o => o.SifraRobe == SelectedArtikal.SifraRobe) != null)
                    {
                        artikli.FirstOrDefault(o => o.SifraRobe == SelectedArtikal.SifraRobe).Kolicina += 1;
                    }
                    else
                    {
                        SelectedArtikal.Kolicina = 1;
                        SelectedArtikal.Rb = artikli.Count() + 1;
                        artikli.Add(SelectedArtikal);

                        
                    }

                    Transakcija = artikli.OrderBy(o => o.Rb).ToList();

                    SelectedArtikal = null;
                    txtCena.Text = "";
                    txtUnos.Text = "";
                    cbArtikliNaStanju.SelectedValue = null;
                    cbArtikliNaStanju.Focus();
                }
            }
        }

        private void cbArtikliNaStanju_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                var izabran = cbArtikliNaStanju.SelectedValue as Roba;

                if (izabran != null)
                {
                    SelectedArtikal = izabran;
                    txtCena.Text = izabran.Cena.ToString("n2");
                    txtUnos.Text = izabran.Cena.ToString("n2");
                    txtUnos.Focus();
                }
            }
        }
    }
}
