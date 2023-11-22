namespace Exo1_Patinoire
{
    internal class Program
    {

        public static readonly string[] ANSWERS_PATINS = { "O", "N" };
        public const double TARIF_ENTER_ADULT = 4.7;
        public const double TARIF_REDUCED = 3.6;
        public const double TARIF_CHILD = 0;
        public const double TARIF_PATINS = 3.5;
        public const int AGE_ADULT = 25;
        public const int AGE_CHILD = 5;
        public const int AGE_OLD = 65;
        
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("CAISSE PATINOIRE");
            Console.WriteLine("---------------------------------");

            // Récupération des entrées utilisateur
            int age = GetAge();
            bool patinsLocation = GetPatinsLocation();

            Console.WriteLine("---------------------------------");

            // Calcul des coûts d'entrée et de location de patins en fonction des entrées utilisateur
            double enterPrice = GetEnterPrice(age);
            double patinsPrice = GetPatinsLocationPrice(patinsLocation);
            double totalPrice = enterPrice + patinsPrice;

            // Affichage des prix finaux d'entrée en fonction des entrées utilisateur
            Console.WriteLine("Prix entree : " + enterPrice + " euros");
            Console.WriteLine("Prix location : " + patinsPrice + " euros");
            Console.WriteLine("Prix total : " + totalPrice + " euros");
        }

        public static double GetEnterPrice(int age)
        {
            if (age < AGE_CHILD) return TARIF_CHILD;
            else if (age <= AGE_ADULT || age >= AGE_OLD) return TARIF_REDUCED;
            else return TARIF_ENTER_ADULT;
        }

        public static double GetPatinsLocationPrice(bool patinsLocation)
        {
            // Si il y a une location de patin, renvoyer le tarif de location, sinon renvoyer le tarif 0 (pas de location)
            return patinsLocation ? TARIF_PATINS : 0;
        }

        public static int GetAge()
        {
            int age = 0;
            bool isInt = false;

            // Boucle pour redemander l'âge de la personne tant que celui-ci n'est pas correct
            do
            {
                Console.WriteLine("Age ?");
                isInt = int.TryParse(Console.ReadLine(), out age);
            } while (!isInt);

            return age;
        }

        public static bool GetPatinsLocation()
        {
            string answer = "";

            // Boucle pour demander à l'utilisateur si il souhaite louer des patins tant que la réponse n'est pas au format attendu (O ou N)
            do
            {
                Console.WriteLine("Location patins ? (O/N)");
                answer = Console.ReadLine();
            } while (string.IsNullOrEmpty(answer) || !ANSWERS_PATINS.Contains(answer.ToUpper()));

            // Renvoie true si la réponse de l'utilisateur vaut O sinon renvoie false
            return (answer.ToUpper() == "O") ? true : false;
        }
    }
}