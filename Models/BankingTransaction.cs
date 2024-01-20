namespace Bank1.Models.Pages
{
    public class BankingTransaction
    {
        public int OperationId { get; set; }
        public int AccountId { get; set; }
        public string OperationType { get; set; }
        public decimal Amount { get; set; }
        public DateTime OperationDate { get; set; }
    }
}