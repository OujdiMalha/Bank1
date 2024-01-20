/*
using System.Numerics;

public interface IOperationService
{
    Task Deposer(int idCompte, decimal montant);
    Task Retirer(int idCompte, decimal montant);
    Task Transfert(int sourceCompte, int destinationCompte, decimal montant);
}

public class OperationService : IOperationService
{
    private readonly List<Compte> comptes;

    public OperationService(ICompteService compteService)
    {
        // Injection du service des comptes pour accéder aux données des comptes
        this.comptes = compteService.GetComptes().Result.ToList();
    }

    public async Task Deposer(int idCompte, decimal montant)
    {
        var compte = comptes.FirstOrDefault(c => c.Id == idCompte);
        if (compte != null)
        {
            compte.Solde += montant;
        }
    }

    public async Task Retirer(int idCompte, decimal montant)
    {
        var compte = comptes.FirstOrDefault(c => c.Id == idCompte);
        if (compte != null && compte.Solde >= montant)
        {
            compte.Solde -= montant;
        }
    }

    public async Task Transfert(int sourceCompte, int destinationCompte, decimal montant)
    {
        var source = comptes.FirstOrDefault(c => c.Id == sourceCompte);
        var destination = comptes.FirstOrDefault(c => c.Id == destinationCompte);

        if (source != null && destination != null && source.Solde >= montant)
        {
            source.Solde -= montant;
            destination.Solde += montant;
        }
    }
}
*/