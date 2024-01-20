/*
using System.Numerics;

public interface ICompteService
{
    Task<int> CreerCompte(Compte compte);
    Task<IEnumerable<Compte>> GetComptes();
}

public class CompteService : ICompteService
{
    private List<Compte> comptes = new List<Compte>();
    private int compteIdCounter = 1;

    public async Task<int> CreerCompte(Compte compte)
    {
        compte.Id = compteIdCounter++;
        comptes.Add(compte);
        return compte.Id;
    }

    public async Task<IEnumerable<Compte>> GetComptes()
    {
        return comptes;
    }
}
*/