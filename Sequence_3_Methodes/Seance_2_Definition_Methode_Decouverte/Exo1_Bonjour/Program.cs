namespace Exo1_Bonjour
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Program.AfficheBonjour();
            String prenom = "Noé";
            Program.AfficheBonjour(prenom);
            Program.AfficheBonjour(prenom, "Dubois");
            Program.AfficheBonjourAvecDate(prenom, "Dubois");
        }

        public static void AfficheBonjour()
        {
            Console.WriteLine("Bonjour");
        }

        public static void AfficheBonjour(String prenom)
        {
            Console.WriteLine("Bonjour " + prenom);
        }

        public static void AfficheBonjour(String prenom, String nom)
        {
            Console.WriteLine("Bonjour " + prenom + " " + nom);
        }

        public static void AfficheBonjourAvecDate(String prenom, String nom)
        {
            string date = DateTime.Today.ToLongDateString();

            Console.WriteLine("Bonjour " + prenom + " " + nom + "\nNous sommes le " + date);
        }
    }
}