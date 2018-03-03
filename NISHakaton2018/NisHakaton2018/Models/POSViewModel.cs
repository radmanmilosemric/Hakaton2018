using Microsoft.AspNetCore.Mvc.Rendering;
using NisHakaton2018.DataModels;
using System.Collections.Generic;

namespace NisHakaton2018.Models
{
    public class POSViewModel
    {
        public List<Roba> ArtikliTransakcije { get; set; }

        public List<SelectListItem> ArtikliNaStanju { get; set; }

        public string IzabranArtikal { get; set; }

        public int Quantity { get; set; }

        public List<Roba> UpareniArtikli { get; set; }
    }
}
