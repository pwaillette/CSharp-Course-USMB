namespace Exo_CourseAPied_TimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------\n" + "COURSE A PIED\n" + "----------------------------------");
            double kilometers = GetKilometers();
            TimeSpan minutes = GetMinutesTimeSpan();
            Console.WriteLine("<=> " + minutes + " minutes");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("VITESSE : " + Course.CalculeVitesse(kilometers, (int)minutes.TotalMinutes));
            Console.WriteLine("----------------------------------");
            Console.WriteLine("OBJECTIFS A ATTEINDRE :");
            Console.WriteLine("----------------------------------");
            double speed = GetSpeed();
            Console.WriteLine("----------------------------------");
            double kms = Course.NbKmPourAtteindreVitesse(minutes, speed);
            Console.WriteLine("Pour avoir une allure moyenne de " + speed + "km/h\n- Avec le même temps, il faut faire " + kms + " kilomètres\n     Soit un progrès de " + (Math.Round(kms - kilometers, 2)) + "km");
            TimeSpan mins = new TimeSpan(0, (int)Course.NbMinPourAtteindreVitesse(kilometers, speed), 0);
            Console.WriteLine("- Avec la même distance, il faut faire " + mins.ToString(@"hh\:mm") + "m\n   Soit un progès de " + Math.Abs(Math.Round(mins.TotalMinutes - minutes.TotalMinutes, 1))  + "m (en -)");
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

        public static TimeSpan GetMinutesTimeSpan()
        {
            Console.WriteLine("Temps (hh:mm) : ");

            return new TimeSpan(0, Course.ConvertitTempsEnMinutes(Console.ReadLine()), 0);
        }
    }
}