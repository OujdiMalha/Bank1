using Bank1.Models.Pages

namespace Bank1.Classes
{
    public class ManagementAccount
    {
        public List<Accounts> GetClientAccounts(int customerId)  // Correction du nom
        {
            // Logique pour récupérer les comptes associés à un client
        }

        public void PerformTransfer(int sourceAccountId, int destinationAccountId, decimal amount)
        {
            // Logique pour effectuer un virement entre deux comptes
        }
    }
}