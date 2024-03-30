namespace Partie1_UnCompte;

public class Compte
{
    public const string MONNAIE = "€";
    private static int _numAuto;

    public Compte(double solde)
    {
        _numAuto++;
        NumCpt = _numAuto;
        Solde = solde;
    }

    public Compte() : this(0)
    {
    }

    public int NumCpt { get; private set; }

    public int NumAuto
    {
        get => _numAuto;
        private set => _numAuto = value;
    }

    public double Solde { get; private set; }

    public void Crediter(double montant)
    {
        if (montant < 0)
            throw new ArgumentException("Le montant à créditer ne peut pas être négatif.", nameof(montant));

        Solde += montant;
    }

    public void Debiter(double montant)
    {
        if (montant < 0) throw new ArgumentException("Le montant à débiter ne peut pas être négatif.", nameof(montant));

        Solde -= montant;
    }

    public override string ToString()
    {
        return $"Compte {NumCpt} - Solde : {Solde}{MONNAIE}";
    }

    public override bool Equals(object obj)
    {
        if (obj is Compte other) return NumCpt == other.NumCpt;
        return false;
    }

    public override int GetHashCode()
    {
        return NumCpt.GetHashCode();
    }

    public static bool operator ==(Compte left, Compte right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(Compte left, Compte right)
    {
        return !left.Equals(right);
    }
}