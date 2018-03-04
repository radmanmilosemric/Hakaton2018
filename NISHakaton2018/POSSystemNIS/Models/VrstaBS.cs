


using System.ComponentModel.DataAnnotations;

namespace NisHakaton2018.DataModels
{
    public class VrstaBS
    {
        [Key]
        public string SifraBS { get; set; }
        public string Naziv { get; set; }
    }
}
