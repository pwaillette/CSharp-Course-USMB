using System.Diagnostics;

namespace Exo1_PlaceConcert
{
    internal class Program
    {
        private static readonly double REMISE_PREVENTE = 1.5;
        private static readonly double REMISE_PERCENT_ADHERENT = 0.2;
        private static readonly int BASEPRICE_PLEIN = 20;
        private static readonly int BASEPRICE_CREUX = 15;
        private static readonly int PLEIN_PRICE_AGE = 20;
        private static readonly int FREE_PRICE_AGE = 10;

        static void Main(string[] args)
        {
            int age = GetAge();

            if (age < FREE_PRICE_AGE)
            {
                PrintPrice(0, false, false, age);
            } 
            else
            {
                bool adherent = IsAdherent();
                bool prevente = IsPrevente();
                double basePrice;

                if (age < PLEIN_PRICE_AGE) basePrice = BASEPRICE_CREUX;
                else basePrice = BASEPRICE_PLEIN;

                PrintPrice(basePrice, prevente, adherent, age);
            }
        }

        static int GetAge()
        {
            Console.WriteLine("Âge ?");
            return int.Parse(Console.ReadLine());
        }

        static bool IsPrevente()
        {
            Console.WriteLine("Place achetée en pré-vente ? (oui/non)");
            return (Console.ReadLine() == "oui") ? true : false;
        }

        static bool IsAdherent()
        {
            Console.WriteLine("Êtes-vous adhérents ? (oui/non)");
            return (Console.ReadLine() == "oui") ? true : false;
        }

        static double GetPrice(double basePrice, bool prevente, bool adherent)
        {
            double reduction = 0;
            if (adherent) reduction += basePrice * REMISE_PERCENT_ADHERENT;
            if (prevente) reduction += REMISE_PREVENTE;

            return Math.Round(basePrice - reduction, 2);
        }

        static void PrintPrice(double price, bool prevente, bool adherent, int age)
        {
            double finalPrice = GetPrice(price, prevente, adherent);
            string str = "Montant initial: " + price + " euros\n";

            if (age > FREE_PRICE_AGE) {
                if (adherent)
                {
                    double reductionTotale = prevente ? Math.Round((price * REMISE_PERCENT_ADHERENT) + 1.5, 2) : Math.Round(price * REMISE_PERCENT_ADHERENT, 2);
                    str += "Réduction : " + reductionTotale + " euros\n";
                }
                else if (prevente) str += "Réduction : 1.5 euros\n";
            }

            str += "Age: " + age + "\nPrix final: " + finalPrice + " euros";

            Console.WriteLine(str);
        }
    }
}