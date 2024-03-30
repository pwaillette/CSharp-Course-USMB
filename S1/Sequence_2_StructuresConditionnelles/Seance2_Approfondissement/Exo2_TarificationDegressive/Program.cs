namespace Exo2_TarificationDegressive
{
    internal class Program
    {
        private static readonly int PALIER_UN = 10;
        private static readonly int PALIER_DEUX = 49;
        private static readonly double PRIX_PALIER_UN = 149.99;
        private static readonly double PRIX_PALIER_DEUX = 134.99;
        private static readonly double PRIX_APRES_PALIER_DEUX = 109.99;

        static void Main(string[] args)
        {
            int quantite = GetQuantity();
            double price = GetPrice(quantite);

            Console.WriteLine("Quantité : " + quantite + "\nPrix final : " + price + " euros");
        }

        static int GetQuantity()
        {
            Console.WriteLine("Quantité achetée : ");
            return int.Parse(Console.ReadLine());
        }

        static double GetPrice(int quantity)
        {
            /*return quantity switch
            {
                < PALIER_UN => PRIX_PALIER_UN,
                <= PALIER_DEUX => PRIX_PALIER_DEUX,
                > PALIER_DEUX => PRIX_APRES_PALIER_DEUX
            } ;*/

            double price;

            if (quantity < PALIER_UN) price = quantity * PRIX_PALIER_UN;
            else if (quantity <= PALIER_DEUX) price = quantity * PRIX_PALIER_DEUX;
            else price =  quantity * PRIX_APRES_PALIER_DEUX;

            return Math.Round(price, 2);
        }
    }
}