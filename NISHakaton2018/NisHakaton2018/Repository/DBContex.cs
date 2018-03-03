using Microsoft.EntityFrameworkCore;
using NisHakaton2018.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NisHakaton2018.Repository
{
    public class DBContex : DbContext
    {
        public DBContex(DbContextOptions<DBContex> options) : base(options)
        {
        }

        public DbSet<KatalogBS> KatalogBS { get; set; }

        public DbSet<Transakcija> Transakcije { get; set; }
    }
}
