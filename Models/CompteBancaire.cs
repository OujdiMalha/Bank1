namespace Bank1.Models.Pages
{
    public class CompteBancaire
    {
        public int CompteId { get; set; }
        public string NumeroCompte { get; set; }
        public decimal Solde { get; set; }
        public string TypeCompte { get; set; }
    }
}