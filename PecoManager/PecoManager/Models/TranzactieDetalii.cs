namespace PecoManager.Models
{
    public class TranzactieDetalii
    {
        public int IdTranzactie { get; set; }
        public string DenumireStatie { get; set; } = string.Empty;
        public string TipCombustibil { get; set; } = string.Empty;
        public DateTime DataOra { get; set; }
        public decimal CantitateaLitri { get; set; }
        public decimal SumaTotala { get; set; }
        public string ModPlata { get; set; } = string.Empty;
    }
}