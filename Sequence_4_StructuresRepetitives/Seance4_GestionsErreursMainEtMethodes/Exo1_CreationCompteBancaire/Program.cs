namespace Exo1_CreationCompteBancaire
{
    internal class Program
    {
        public static readonly double TARIF_IMMEDIAT = 31.5;
        public static readonly double TARIF_DIFFERE = 42.5;
        public static readonly double TAUX_PREFERENTIEL_JEUNE = 0.5;
        public static readonly int AGE_PREFERENTIEL = 25;
        public static readonly int AGE_MINIMAL = 16;

        public static void Main(string[] args)
        {
            Console.WriteLine("Ouverture compte 11 ans :"
            + Program.OuvertureCompteCheque(11));
            Console.WriteLine("Ouverture compte 18 ans :"
            + Program.OuvertureCompteCheque(18));
            // Console.WriteLine("Ouverture compte -8 ans :"
            // + Program.OuvertureCompteCheque(-8));

            Console.WriteLine("Prix différé 35 ans :" + Program.PrixCarteBleue("D", 35));
            Console.WriteLine("Prix immédiat 35 ans :" + Program.PrixCarteBleue("I", 35));
            Console.WriteLine("Prix différé 25 ans :" + Program.PrixCarteBleue("D", 25));
            Console.WriteLine("Prix immédiat 25 ans :" + Program.PrixCarteBleue("I", 25));
            // Console.WriteLine("Prix immédiat 25 ans :" + Program. PrixCarteBleue ("IM", 25));
            // Console.WriteLine("Prix différé 5 ans :"+Program. PrixCarteBleue ("D", 5));
        }

        public static bool OuvertureCompteCheque(int age)
        {
            if (age < 0) throw new ArgumentOutOfRangeException("L'âge doit être supérieur à 0.");
            return (age >= AGE_MINIMAL) ? true : false;
        }

        public static double PrixCarteBleue(String debit, int age)
        {
            if (!Program.OuvertureCompteCheque(age)) throw new ArgumentException("Impossible d'ouvrir un compte pour des personnes de moins de 16 ans");
            if (debit == null || (debit != "D" && debit != "I")) throw new ArgumentException("Débit invalide: D ou I");

            double tarif = (debit == "D") ? 42.5 : 31.5;
            tarif = (age >= 16 && age <= 25) ? tarif / 2 : tarif;

            return tarif;
        }
    }
}