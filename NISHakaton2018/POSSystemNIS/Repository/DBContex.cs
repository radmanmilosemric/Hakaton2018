using Microsoft.EntityFrameworkCore;
using NisHakaton2018.DataModels;

namespace NisHakaton2018.Repository
{
    public class DBContex : DbContext
    {
        public DBContex(DbContextOptions<DBContex> options) : base(options)
        {
        }

        public DbSet<KatalogBS> KatalogBS { get; set; }
        public DbSet<Transactions> Transakcije { get; set; }
        public DbSet<GrupaRobe> GrupaRobe { get; set; }
        public DbSet<Roba> Roba { get; set; }
        public DbSet<HijerarhijaRobe> HijerarhijaRobe { get; set; }
        public DbSet<VrstaBS> VrstaBS { get; set; }
    }
}
