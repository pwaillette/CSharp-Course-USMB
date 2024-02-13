namespace Exo5_AppelTelephonique
{
    internal class Program
    {

        private static readonly double TARIF_NATIONAL_CREUSE = 0.1;
        private static readonly double TARIF_NATIONAL_PLEINE = 0.2;
        private static readonly double TARIF_INTERNATIONAL_CREUSE = 0.15;
        private static readonly double TARIF_INTERNATIONAL_PLEINE = 0.23;

        static void Main(string[] args)
        {
            int duree = GetDuree();
            double prixAppel;
            string destination = GetDestination(), tarif = GetTarif();

            if (destination == "national")
            {
                if (tarif == "creuse") prixAppel = duree * TARIF_NATIONAL_CREUSE;
                else prixAppel = duree * TARIF_NATIONAL_PLEINE;
            }
            else
            {
                if (tarif == "creuse") prixAppel = duree * TARIF_INTERNATIONAL_CREUSE;
                else prixAppel = duree * TARIF_INTERNATIONAL_PLEINE;
            }

            Console.WriteLine("Prix de votre appel : " + Math.Round(prixAppel, 2) + " euros");
        }

        static int GetDuree()
        {
            Console.WriteLine("Nombre d'heure.s de l'appel ?");
            int nbHeure = int.Parse(Console.ReadLine());

            Console.WriteLine("Nombre de minute.s de l'appel ?");
            int nbMin = int.Parse(Console.ReadLine());

            return (nbHeure * 60) + nbMin;
        }

        static string GetDestination()
        {
            Console.WriteLine("Destination de l'appel ? (national/international)");
            return Console.ReadLine();
        }

        static string GetTarif()
        {
            Console.WriteLine("Tarif de l'appel ? (creuse/plein)");
            return Console.ReadLine();
        }
    }
}