namespace Partie1_UnCompte;

public class CompteBloque : Compte
{

    private double _seuilMin;

    public CompteBloque() : base()
    {
        SeuilMin = 0;
    }

    public CompteBloque(string nom, string numero, decimal solde) : base(nom, numero, solde)
    {
        SeuilMin = 0;
    }

    public CompteBloque(double seuilMin) : this()
    {
        SeuilMin = seuilMin;
    }

    public CompteBloque(decimal solde, double seuilMin): base(solde)
    {
        Solde = solde;
        SeuilMin = seuilMin;
    }

    public override bool Debiter(decimal montant)
    {
        decimal newDebit = Solde - montant;
        if (newDebit > (decimal)SeuilMin)
        {
            Solde -= montant;
            Operations.Add(new Operation { Date = DateTime.Now, Heure = DateTime.Now.TimeOfDay, Type = TypeOperation.Debit, Description = "Débit", Montant = montant });
            return true;
        }
        return false;
    }

    public double SeuilMin
    {
        get => _seuilMin;
        set
        {
            if (value > 0) throw new ArgumentException("Le seuil minimal ne peut pas être supérieur à 0");
            _seuilMin = value;
        }
    }

    public override string ToString()
    {
        return base.ToString() + "\nSeuil min : " + this.SeuilMin;
    }
}