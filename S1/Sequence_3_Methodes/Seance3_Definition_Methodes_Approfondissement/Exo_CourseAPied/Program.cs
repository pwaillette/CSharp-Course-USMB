namespace Exo_CourseAPied
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------\n" + "COURSE A PIED\n" + "----------------------------------");
            double kilometers = GetKilometers();
            int minutes = GetMinutes();
            Console.WriteLine("<=> " + minutes + " minutes");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("VITESSE : " + Course.CalculeVitesse(kilometers, minutes));
            Console.WriteLine("----------------------------------");
            Console.WriteLine("OBJECTIFS A ATTEINDRE :");
            Console.WriteLine("----------------------------------");
            double speed = GetSpeed();
            Console.WriteLine("----------------------------------");
            double kms = Course.NbKmPourAtteindreVitesse(minutes, speed);
            Console.WriteLine("Pour avoir une allure moyenne de " + speed + "km/h\n- Avec le même temps, il faut faire " + kms + " kilomètres\n     Soit un progrès de " + (Math.Round(kms - kilometers, 2)) + "km");
            double mins = Course.NbMinPourAtteindreVitesse(kilometers, speed);
            Console.WriteLine("- Avec la même distance, il faut faire " + Course.ConvertitMinutesEnTemps((int)mins) + "m\n   Soit un progès de " + Math.Abs(Math.Round(mins - minutes, 1))  + "m (en -)");
        }

        public static double GetSpeed()
        {
            Console.WriteLine("Vitesse à atteindre : ");
            double speed;
            bool speedB = double.TryParse(Console.ReadLine(), out speed);

            return speedB ? speed : 0;
        }

        public static double GetKilometers()
        {
            Console.WriteLine("Nombre de kilomètres parcourus : ");
            double kms;
            bool kmsB = double.TryParse(Console.ReadLine(), out kms);

            return kmsB ? kms : 0;
        }

        public static int GetMinutes()
        {
            Console.WriteLine("Temps (hh:mm) : ");

            return Course.ConvertitTempsEnMinutes(Console.ReadLine());
        }
    }
}