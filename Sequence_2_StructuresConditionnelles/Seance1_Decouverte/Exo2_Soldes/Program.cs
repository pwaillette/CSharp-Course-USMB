namespace Exo2_Soldes
{
    internal class Program
    {
        private static readonly double REMISE_ROUGE = 0.5;
        private static readonly double REMISE_VERT = 0.2;

        static void Main(string[] args)
        {
            string couleur = GetCouleur();
            double prix = GetPrix(), 
                remise = GetRemise(couleur), 
                remisePrix = prix * remise, 
                prixFinal = prix - remisePrix;

            Console.WriteLine("Prix final: " + prixFinal + "\nRemise de: " + remisePrix);
        }

        static double GetPrix()
        {
            double prix;
            Console.WriteLine("Prix ?");
            prix = double.Parse(Console.ReadLine());
            return prix;
        }

        static string GetCouleur()
        {
            string couleur;
            Console.WriteLine("Couleur de l'étiquette ?");
            couleur = Console.ReadLine();
            return couleur;
        }

        static double GetRemise(string couleur)
        {
            return (couleur == "V") ? REMISE_VERT : REMISE_ROUGE;
        }
    }
}