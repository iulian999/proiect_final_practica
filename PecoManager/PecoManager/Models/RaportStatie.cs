namespace PecoManager.Models
{
    public class RaportStatie
    {
        public string DenumireStatie { get; set; } = string.Empty;
        public string Oras { get; set; } = string.Empty;
        public int NrTranzactii { get; set; }
        public decimal TotalIncasat { get; set; }
    }
}