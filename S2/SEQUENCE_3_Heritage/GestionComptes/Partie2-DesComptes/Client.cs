namespace Partie2_DesComptes;

public class Client
{
    public string Nom
    {
        get => _nom;
        set => _nom = value ?? throw new ArgumentNullException(nameof(value));
    }
    
    public List<Compte> SesComptes
    {
        get => _sesComptes;
        set => _sesComptes = value ?? throw new ArgumentNullException(nameof(value));
    }

    private string _nom;
    private List<Compte> _sesComptes;

    public Client(string nom)
    {
        Nom = nom;
        SesComptes = new List<Compte>();
    }
    
    public Client(string nom, List<Compte> sesComptes)
    {
        Nom = nom;
        SesComptes = sesComptes;
    }
    
    public void AjouterCompte(Compte compte)
    {
        SesComptes.Add(compte);
    }
    
    public void Crediter(string numeroCompte, decimal montant)
    {
        Compte compte = SesComptes.Find(c => c.Numero == numeroCompte);
        if (compte == null) throw new InvalidOperationException("Le compte n'existe pas.");
        compte.Crediter(montant);
    }
    
    public void Debiter(string numeroCompte, decimal montant)
    {
        Compte compte = SesComptes.Find(c => c.Numero == numeroCompte);
        if (compte == null) throw new InvalidOperationException("Le compte n'existe pas.");
        compte.Debiter(montant);
    }
    
    public Compte RechercherCompte(string numeroCompte)
    {
        return SesComptes.Find(c => c.Numero == numeroCompte);
    }
}