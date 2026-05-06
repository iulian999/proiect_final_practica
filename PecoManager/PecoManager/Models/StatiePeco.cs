namespace PecoManager.Models
{
    public class StatiePeco
    {
        public int IdStatie { get; set; }
        public string Denumire { get; set; } = string.Empty;
        public string Adresa { get; set; } = string.Empty;
        public string Oras { get; set; } = string.Empty;
        public int NrPompe { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}