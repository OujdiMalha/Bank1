namespace Bank1.Services
{
    public interface IOperationService
    {
        Task Deposer(int idCompte, decimal montant);
        Task Retirer(int idCompte, decimal montant);
        Task Transfert(int sourceCompte, int destinationCompte, decimal montant);
    }
}
