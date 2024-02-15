namespace GestionCompte
{
    internal class Compte
    {
        public const string MONNAIE = "€";
        private static int numAuto = 0;

        private int numCpt;
        private double solde;

        public Compte() {
            Compte.NumAuto++;
            this.NumCpt = Compte.NumAuto;
            this.Solde = 0;
        }

        public Compte(double solde) 
        {
            Compte.NumAuto++;
            this.NumCpt = Compte.NumAuto;

            if (solde >= 0)
            {
                this.Solde = solde;
            }
            else throw new ArgumentException("Le solde de départ ne peut pas être inférieur à 0 !");
        }

        public bool Crediter(double montant)
        {
            if (montant < 0) throw new ArgumentException("Le montant à créditer ne peut pas être inférieur à 0 !");
            this.Solde += montant;
            return true;
        }

        public bool Debiter(double montant)
        {
            if (montant < 0) throw new ArgumentException("Le montant à débiter ne peut pas être inférieur à 0 !");
            this.Solde -= montant;
            return true;
        }

        public static int NumAuto { get => numAuto; private set => numAuto = value; }
        public int NumCpt { get => numCpt; private set => numCpt = value; }
        public double Solde { get => solde; private set => solde = value; }

        public override bool Equals(object? obj)
        {
            return obj is Compte compte &&
                   NumCpt == compte.NumCpt;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(NumCpt, Solde);
        }

        public override string ToString()
        {
            return $"Compte n°{NumCpt}\nSolde: {Solde}{MONNAIE}";
        }
    }
}
