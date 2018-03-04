
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace POSSystemNIS.Models
{

    [Table("PairedItems")]
    public class PairedItem
    {
        [Key]
        public int PairedItemId { get; set; }
        public string TstSifraRobe { get; set; }
        public string TstNazivRobe { get; set; }
        public string TndSifraRobe { get; set; }
        public string TndNazivRobe { get; set; }
        public int RankNo { get; set; }
        public int Count { get; set; }
        public int PartOfDay { get; set; }
        public string SifraBS { get; set; }
        public bool IsWeekend { get; set; }

    }
}
