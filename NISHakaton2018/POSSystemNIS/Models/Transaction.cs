
using System;
using System.ComponentModel.DataAnnotations;

namespace NisHakaton2018.DataModels
{
    public class Transactions
    {
        [Key]
        public int TransactionId { get; set; }
        public string SifraBS { get; set; }
        public string BrojRacuna { get; set; }
        public string BrojStavke { get; set; }
        public string Datum { get; set; }
        public string Vreme { get; set; }
        public string TipKupca { get; set; }
        public string SifraRobe { get; set; }
        public string NazivRobe { get; set; }
        public string VrstaRobe { get; set; }
        public string GrupaRobe { get; set; }
        public string HijerarhijaRobe { get; set; }
        public string Kolicina { get; set; }
        public string KonacnaCena { get; set; }
        public string OsnovnaCena { get; set; }
        public string KompanijskaKartica { get; set; }
        public string LoyaltyKartica { get; set; }
        public string LoyaltyKarticaStatus { get; set; }
        public string LoyaltyPoeni { get; set; }
        public decimal? KolicinaDec { get; set; }
        public decimal? KonacnaCenaDec { get; set; }
        public decimal? OsnovnaCenaDec { get; set; }
        public decimal? LoyaltyPoenidec { get; set; }
        public DateTime? TransactionDate { get; set; } }
}
