using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 

namespace POSSystemNIS.Models
{
    [Table("KupacProizvod")]
    public class KupacProizvod
    {
        [Key]
        public int ID { get; set; }
        public string LoyaltyKartica { get; set; }
        public string SifraRobe { get; set; }
        public int BrojKupovina { get; set; }
    }
}
