


using System.ComponentModel.DataAnnotations;

namespace NisHakaton2018.DataModels
{
    public class Roba
    {
        [Key]
        public string SifraRobe { get; set; }
        public string NazivRobe { get; set; }
        public string VrstaRobe { get; set; }
        public string GrupaRobe { get; set; }
        public string HirearhijaRobe { get; set; }

        public double Cena { get; set; }
        public int Kolicina { get; set; }
        public int Rb { get; set; }

        public string ForSearch
        {
            get
            {
                return SifraRobe + " | " +
                    NazivRobe + " | " +
                    VrstaRobe + " | " +
                    GrupaRobe;
            }
        }
    }
}
