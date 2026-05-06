namespace PecoManager.Models
{
    public class Combustibil
    {
        public int IdCombustibil { get; set; }
        public string Tip { get; set; } = string.Empty;
        public decimal PretPerLitru { get; set; }
        public decimal StocLitri { get; set; }
    }
}