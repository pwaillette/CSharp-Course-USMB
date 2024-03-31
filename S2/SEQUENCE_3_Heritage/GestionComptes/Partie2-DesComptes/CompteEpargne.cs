namespace Partie2_DesComptes;

public class CompteEpargne : CompteBloque
{
    private decimal seuilMax;
    private decimal txEpargne;

    public CompteEpargne() : base()
    {
        SeuilMax = 0;
        TxEpargne = 0;
    }
    
    public CompteEpargne(string nom, string numero, decimal solde) : base(nom, numero, solde)
    {
        SeuilMax = 0;
        TxEpargne = 0;
    }
    
    public decimal SeuilMax
    {
        get => seuilMax;
        set {
            if (value < 0) throw new ArgumentOutOfRangeException(nameof(txEpargne), "Le taux d'épargne doit être supérieur à 0 !"); 
            seuilMax = value;
        }
    }

    public decimal TxEpargne { 
        get => txEpargne;
        set
        {
            if (value < 0 || value > 1)
                throw new ArgumentOutOfRangeException(nameof(txEpargne), "Le taux d'épargne doit être compris entre 0 et 1.");
            txEpargne = value;
        }
    }
    
    public override string ToString()
    {
        return $"Compte Épargne: Solde = {base.Solde}, Taux d'épargne = {this.txEpargne}, Seuil Max = {this.seuilMax}";
    }

    public void Crediter(decimal montant)
    {
        if (base.Solde + montant > seuilMax)
            throw new InvalidOperationException("Impossible de créditer car cela dépasserait le seuil max.");

        base.Crediter(montant);
    }

    public decimal CalculFuturMontant(int nbAnnee)
    {
        // Formule de calcul de la valeur future : Vf = Vi * (1 + ρ)^a
        decimal valeurFuture = Solde * (decimal)Math.Pow(1 + Decimal.ToDouble(TxEpargne), nbAnnee);
        return valeurFuture;
    }
    
    public decimal CalculInteret(int nbAnnee)
    {
        // Formule de calcul des intérêts : Interet = Vf - Vi
        decimal valeurFuture = CalculFuturMontant(nbAnnee);
        decimal interet = valeurFuture - base.Solde;
        return interet;
    }

    public int CalculNbAnnee(decimal montantAAtteindre)
    {
        if (montantAAtteindre <= Solde)
            return 0; // Aucune année n'est nécessaire si le montant à atteindre est inférieur ou égal au solde actuel

        if (txEpargne <= 0)
            throw new InvalidOperationException("Le taux d'épargne doit être supérieur à 0 pour calculer le nombre d'années.");

        // Formule de calcul du nombre d'années : a = (log(Vf/Vi) / log(1 + ρ))
        int nbAnnee = (int)Math.Ceiling(Math.Log((double)montantAAtteindre / (double)base.Solde) / Math.Log(1 + Decimal.ToDouble(TxEpargne)));

        return nbAnnee;
    }
}