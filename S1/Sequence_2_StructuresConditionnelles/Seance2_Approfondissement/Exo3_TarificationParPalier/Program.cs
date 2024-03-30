namespace Exo3_TarificationParPalier
{
    internal class Program
    {
        private static readonly double TARIF_NEUF_ARTICLES = 149.99;
        private static readonly double TARIF_QUARANTE_ARTICLES = 134.99;
        private static readonly double TARIF_ARTICLES_SUPPLEMENTAIRES = 109.99;
        private static readonly int PALIER_UN = 9;
        private static readonly int PALIER_DEUX = 40;

        static void Main(string[] args)
        {
            int quantity = GetQuantity();
            double price = GetPrice(quantity);

            Console.WriteLine("Quantité : " + quantity + "\nPrix total : " + price);
        }

        static int GetQuantity()
        {
            Console.WriteLine("Quantité d'articles ?");
            return int.Parse(Console.ReadLine());
        }

        static double GetPrice(int quantity)
        {
            double price;

            if (quantity >= PALIER_UN)
            {
                price = TARIF_NEUF_ARTICLES * PALIER_UN;
                quantity -= PALIER_UN;

                if (quantity >= PALIER_DEUX)
                {
                    price += TARIF_QUARANTE_ARTICLES * PALIER_DEUX;
                    quantity -= PALIER_DEUX;

                    if (quantity > 0)
                    {
                        price += quantity * TARIF_ARTICLES_SUPPLEMENTAIRES;
                    }
                }
                else price += TARIF_QUARANTE_ARTICLES * quantity;
            }
            else price = quantity * TARIF_NEUF_ARTICLES;

            return Math.Round(price, 2);
        }
    }
}