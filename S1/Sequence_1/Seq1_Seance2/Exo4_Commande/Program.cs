namespace Exo4_Commande
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double REMISE = 0.05; // Déclaration des constantes
            const double FRAIS_PORT = 0.02; // Déclaration des constantes

            double pxUnitaire, px, montant, remise, fraisPort, montantFinal; // Déclaration des variables
            int qte; // Déclaration des variables

            Console.WriteLine("Prix unitaire ?");
            pxUnitaire = double.Parse(Console.ReadLine()); // Récupération du prix unitaire
            Console.WriteLine("Quantité ?");
            qte = int.Parse(Console.ReadLine()); // Récupération de la quantité

            px = pxUnitaire * qte; // Calcul du prix ht
            remise = Math.Round(px * REMISE, 2); // Calcul de la remise
            fraisPort = Math.Round(px * FRAIS_PORT, 2); // Calcul du frais de port
            montantFinal = (px - remise) + fraisPort; // Calcul du montant final

            Console.WriteLine("Prix total : " + montantFinal + "\nRemise : " + remise + "\nFrais de port : " + fraisPort + "\nMontant : " + px); // Affichage du résultat
        }
    }
}