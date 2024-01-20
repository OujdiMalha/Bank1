namespace Bank1.Models.Pages
{
    public class Accounts
    {
        public int AccountId { get; set; }
        public int CustomerId { get; set; }  
        public string AccountNumber { get; set; }
        public decimal Solde { get; set; }
        public string AccountType { get; set; }
    }
}