namespace Bank1.Models.Pages
{
    public class OperationBancaire
    {
        public int OperationId { get; set; }
        public int CompteId { get; set; }
        public string TypeOperation { get; set; }
        public decimal Montant { get; set; }
        public DateTime DateOperation { get; set; }
    }
}