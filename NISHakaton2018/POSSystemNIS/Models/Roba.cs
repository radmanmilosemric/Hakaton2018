using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NisHakaton2018.DataModels
{
    [Table("Roba")]
    public class Roba
    {
        [Key]
        public string SifraRobe { get; set; }
        public string NazivRobe { get; set; }
        public string VrstaRobe { get; set; }
        public string GrupaRobe { get; set; }
        public string HirearhijaRobe { get; set; }

        public decimal Cena { get; set; }
        [NotMapped]
        public int Kolicina { get; set; }
        [NotMapped]
        public int Rb { get; set; }
        [NotMapped]
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
