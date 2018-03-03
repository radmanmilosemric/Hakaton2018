using NisHakaton2018.DataModels;
using System.Collections.Generic;
using System.Linq;

namespace NisHakaton2018.Repository
{
    public class RepoTransakcije
    {
        private readonly DBContex _context;
        public RepoTransakcije(DBContex context)
        {
            _context = context;
        }
    }
}
