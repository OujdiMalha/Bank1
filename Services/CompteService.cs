// CompteService.cs
using Bank1.Models.Pages;

public class CompteService
{
    private List<CompteBancaire> comptesBancaires;

    public CompteService()
    {
        // Initialisation des données (remplacez cela par la logique de récupération réelle)
        comptesBancaires = new List<CompteBancaire>
        {
            new CompteBancaire { CompteId = 1, NumeroCompte = "123456789", Solde = 1000.00m, TypeCompte = "Épargne" },
            new CompteBancaire { CompteId = 2, NumeroCompte = "987654321", Solde = 500.00m, TypeCompte = "Chèques" },
            // Ajoutez plus de comptes au besoin
        };
    }

    public List<CompteBancaire> GetComptesBancaires()
    {
        return comptesBancaires;
    }
}