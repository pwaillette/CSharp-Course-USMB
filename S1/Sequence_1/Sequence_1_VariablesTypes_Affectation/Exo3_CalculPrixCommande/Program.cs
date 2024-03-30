namespace Exo3_CalculPrixCommande
{
    internal class Program
    {
        static readonly double TAUX_TVA = 0.20;

        static void Main(string[] args)
        {
            int quantite;
            double prixHT, prixTTC, prixHTUnitaire;

            Console.WriteLine("CALCUL DU PRIX DE LA COMMANDE");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Quantité :");
            quantite = int.Parse(Console.ReadLine());
            Console.WriteLine("Prix HT Unitaire :");
            prixHTUnitaire = double.Parse(Console.ReadLine());

            prixHT = Math.Round(prixHTUnitaire * quantite, 2);
            prixTTC = Math.Round(prixHT + (prixHT * TAUX_TVA), 2);

            Console.WriteLine("Prix HT : " + prixHT);
            Console.WriteLine("Prix TTC : " + prixTTC);
        }
    }
}