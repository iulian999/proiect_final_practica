namespace PecoManager.Models
{
    public class Tranzactie
    {
        public int IdTranzactie { get; set; }
        public int IdStatie { get; set; }
        public int IdCombustibil { get; set; }
        public DateTime DataOra { get; set; }
        public decimal CantitateaLitri { get; set; }
        public decimal SumaTotala { get; set; }
        public string ModPlata { get; set; } = string.Empty;
    }
}