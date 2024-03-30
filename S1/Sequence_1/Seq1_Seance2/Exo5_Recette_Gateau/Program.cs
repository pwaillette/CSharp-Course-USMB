namespace Exo5_Recette_Gateau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double SUCRE = 0.1; // Déclaration des constantes
            const double BEURRE = 0.25; // Déclaration des constantes
            const double FARINE = 0.5; // Déclaration des constantes
            const double CHOCOLAT = 0.15; // Déclaration des constantes

            double poids, sucre, farine, beurre, chocolat; // Déclaration des variables

            Console.WriteLine("Poids ? (kg, g..)");
            poids = double.Parse(Console.ReadLine()); // Récupération du poids

            sucre = poids * SUCRE; // Calcul de la quantité de sucre
            beurre = poids * BEURRE; // Calcul de la quantité de beurre
            farine = poids * FARINE; // Calcul de la quantité de farine
            chocolat = poids * CHOCOLAT; // Calcul de la quantité de chocolat

            Console.WriteLine("Sucre: " + sucre + "\nBeurre: " + beurre + "\nFarine: " + farine + "\nChocolat: " + chocolat); // Affichage des résultats
        }
    }
}