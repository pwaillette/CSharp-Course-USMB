using System.Net.NetworkInformation;

namespace Exo7_InteretsBancaires
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int depot, nbAnnees; // Déclaration des variables
            double taux, futurMontant, gain; // Déclaration des variables

            Console.WriteLine("Depot ?");
            depot = int.Parse(Console.ReadLine()); // Récupération du dépôt

            Console.WriteLine("Taux ?");
            taux = double.Parse(Console.ReadLine()); // Récupération du taux

            Console.WriteLine("Nb années ?");
            nbAnnees = int.Parse(Console.ReadLine()); // Récupération du nombre d'années

            futurMontant = Math.Round(depot * Math.Pow((1 + taux), nbAnnees), 2); // Calcul du futur montant
            gain = Math.Round(futurMontant - depot, 2); // Calcul du gain

            Console.WriteLine("Dans " + nbAnnees + " année(s), tu auras " + futurMontant + " euros"); // Affichage des résultats
            Console.WriteLine("Un gain de " + gain + " euros");
        }
    }
}