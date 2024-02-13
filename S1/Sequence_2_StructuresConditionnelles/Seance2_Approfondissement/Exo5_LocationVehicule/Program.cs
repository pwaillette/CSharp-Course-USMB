namespace Exo5_LocationVehicule
{
    internal class Program
    {
        private static readonly int VOITURE_PLAZZA_ORDINAIRE = 29;
        private static readonly int VOITURE_PLAZZA_LUXE = 33;
        private static readonly int VOITURE_RIVIERA_ORDINAIRE = 27;
        private static readonly int VOITURE_RIVIERA_LUXE = 30;
        private static readonly int PLAZZA_SEMAINE = 753;
        private static readonly int PLAZZA_JOURSUPP = 47;
        private static readonly int RIVIERA_SEMAINE = 784;
        private static readonly int RIVIERA_JOURSUPP = 44;

        static void Main(string[] args)
        {
            string hotel = GetHotel();
            int jours = GetNombreJours();
            bool voiture = IsCar();
            string carQuality = GetCarQuality(voiture);
            int nbJoursCar = GetCarNombreJours(voiture);

            double hotelPrice = getHotelPrice(hotel, jours), carPrice = (voiture) ? getCarPrice(hotel, carQuality, nbJoursCar) : 0;
            double totalPrice = hotelPrice + carPrice;

            Console.WriteLine("Prix de l'hôtel : " + hotelPrice + "\nPrix de la voiture : " + carPrice + "\nPrix total : " + totalPrice);
        }

        static double getHotelPrice(string hotel, int jours)
        {
            double price;
            if (hotel == "Plazza")
            {
                price = PLAZZA_SEMAINE;
                jours -= 7;

                if (jours > 0) price += jours * PLAZZA_JOURSUPP;
            }
            else
            {
                price = RIVIERA_SEMAINE;
                jours -= 7;

                if (jours > 0) price += jours * RIVIERA_JOURSUPP;
            }

            return price;
        }

        static double getCarPrice(string hotel, string type, int jours)
        {
            double price;
            if (hotel == "Plazza")
            {
                price = (type == "Ordinaire") ? jours * VOITURE_PLAZZA_ORDINAIRE : jours * VOITURE_PLAZZA_LUXE;
            } else
            {
                price = (type == "Ordinaire") ? jours * VOITURE_RIVIERA_ORDINAIRE : jours * VOITURE_RIVIERA_LUXE;
            }

            return price;
        }

        static double getPricePerWeek(int price)
        {
            return price * 7;
        }

        static string GetHotel()
        {
            Console.WriteLine("Veuillez entrer l'hôtel choisi (Plazza/Riviera) :");
            return Console.ReadLine();
        }

        static int GetNombreJours()
        {
            Console.WriteLine("Combien de jours restez-vous à l'hôtel ?");
            return int.Parse(Console.ReadLine());
        }

        static int GetCarNombreJours(bool voiture)
        {
            if (!voiture) return 0;

            Console.WriteLine("Combien de jours empruntez-vous la voiture ?");
            return int.Parse(Console.ReadLine());
        }

        static bool IsCar()
        {
            Console.WriteLine("Empruntez-vous une voiture ? (oui/non)");
            return (Console.ReadLine() == "oui") ? true : false;
        }

        static string GetCarQuality(bool iscar)
        {
            if (!iscar) return null;

            Console.WriteLine("Quelle qualité de voiture ? (Ordinaire/Luxe)");
            return Console.ReadLine();
        }
    }
}