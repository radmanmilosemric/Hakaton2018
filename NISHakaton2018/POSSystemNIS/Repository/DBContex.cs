
using NisHakaton2018.DataModels;
using POSSystemNIS.Models;
using System.Data.Entity;

namespace NisHakaton2018.Repository
{
    public class DBContex : DbContext
    {
        public DBContex() : base("name=DefaultConnection")
        {

        }

        public DbSet<KatalogBS> KatalogBS { get; set; }
        public DbSet<Transactions> Transakcije { get; set; }
        public DbSet<GrupaRobe> GrupaRobe { get; set; }
        public DbSet<Roba> Roba { get; set; }
        public DbSet<HijerarhijaRobe> HijerarhijaRobe { get; set; }
        public DbSet<VrstaBS> VrstaBS { get; set; }
        public DbSet<PairedItem> PairedItems { get; set; }
        public DbSet<KupacProizvod> KupacProizvodList { get; set; }
    }
}
