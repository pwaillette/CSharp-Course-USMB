namespace Exo3_MesFctString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String prenom = "Aiko";
            String nom = "sama";

            Console.WriteLine(Initiales(prenom, nom));
            Console.WriteLine(Email(prenom, nom));
        }

        public static string Initiales(String prenom, String nom)
        {
            return prenom.Substring(0, 1).ToUpper() + "." + nom.Substring(0, 1).ToUpper() + ".";
        }

        public static string Email(String prenom, String nom)
        {
            return prenom.ToLower() + "." + nom.ToLower() + "@etu.univ-smb.fr";
        }
    }
}