namespace Exo2_Moyenne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nb1, nb2;
            double moyenne; // Initialisation des variables

            Console.Write("nb1 ?");
            nb1 = int.Parse(Console.ReadLine()); // Récupération du nombre 1

            Console.Write("nb2 ?");
            nb2 = int.Parse(Console.ReadLine()); // Récupération du nombre 2

            moyenne = (double)(nb1 + nb2) / 2; // Calcul de la moyenne

            Console.WriteLine("Moyenne : " + moyenne); // Affichage du résultat
        }
    }
}