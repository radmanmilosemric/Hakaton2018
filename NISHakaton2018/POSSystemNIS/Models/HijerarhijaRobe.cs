
using System.ComponentModel.DataAnnotations;

namespace NisHakaton2018.DataModels
{
    public class HijerarhijaRobe
    {
        [Key]
        public int Id { get; set; }
        public string Hijerarhija { get; set; }
        public string Grupa { get; set; }
    }
}
