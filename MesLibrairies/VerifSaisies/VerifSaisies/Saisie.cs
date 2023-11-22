namespace VerifSaisies
{
    public class Saisie
    {
        public static int SaisieInt()
        {
            int res;
            bool reussi = int.TryParse(Console.ReadLine(), out res);
            while (!reussi)
            {
                Console.WriteLine("Erreur de saisie. Il faut un entier : ");
                reussi = int.TryParse(Console.ReadLine(), out res);
            }
            return res;
        }

        public static int SaisieUInt()
        {
            uint res;
            bool reussi = uint.TryParse(Console.ReadLine(), out res);
            while (!reussi)
            {
                Console.WriteLine("Erreur de saisie. Il faut un entier non signé (>=0) : ");
                reussi = uint.TryParse(Console.ReadLine(), out res);
            }
            return (int)res; // Cast le résultat en int si nécessaire
        }

        public static double SaisieDouble()
        {
            double res;
            bool reussi = double.TryParse(Console.ReadLine().Replace(',', '.'), out res);
            while (!reussi)
            {
                Console.WriteLine("Erreur de saisie. Il faut un nombre réel : ");
                reussi = double.TryParse(Console.ReadLine().Replace(',', '.'), out res);
            }
            return res;
        }

        public static double SaisieDoublePositif()
        {
            double res;
            bool reussi = double.TryParse(Console.ReadLine().Replace(',', '.'), out res);
            while (!reussi || res < 0)
            {
                Console.WriteLine("Erreur de saisie. Il faut un nombre réel positif : ");
                reussi = double.TryParse(Console.ReadLine().Replace(',', '.'), out res);
            }
            return res;
        }

        public static double SaisieDoublePositif(double min, double max)
        {
            double res;
            bool reussi = double.TryParse(Console.ReadLine().Replace(',', '.'), out res);
            while (!reussi || res < min || res > max)
            {
                Console.WriteLine($"Erreur de saisie. Il faut un nombre réel positif entre {min} et {max} : ");
                reussi = double.TryParse(Console.ReadLine().Replace(',', '.'), out res);
            }
            return res;
        }

        public static DateTime SaisieDateTime()
        {
            DateTime res;
            bool reussi = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out res);
            while (!reussi)
            {
                Console.WriteLine("Erreur de saisie. Format attendu : JJ/MM/AAAA : ");
                reussi = DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out res);
            }
            return res;
        }

        public static string SaisiePlaqueImmatriculation()
        {
            string res = "";
            bool reussi = false;
            while (!reussi)
            {
                res = Console.ReadLine();
                reussi = System.Text.RegularExpressions.Regex.IsMatch(res, @"^[A-Z]{2}-\d{3}-[A-Z]{2}$");
                if (!reussi)
                {
                    Console.WriteLine("Erreur de saisie. Format attendu : AA-000-AA");
                }
            }
            return res;
        }

        public static string SaisieStringParmis(string input, params string[] allowedInputs)
        {
            bool correct = false;
            string userInput = "";
            do
            {
                Console.WriteLine(input + " (" + string.Join(", ", allowedInputs) + ")");
                userInput = Console.ReadLine();

                if (userInput != null && allowedInputs.Contains(userInput)) correct = true;
            } while (!correct);

            return userInput;
        }

        public static char SaisieUnCaracParmiDeuxChoix(string message, string choix1, string choix2)
        {
            char res;
            bool reussi = false;
            do
            {
                Console.WriteLine($"{message} ({choix1[0]}/{choix2[0]}) : ");
                reussi = char.TryParse(Console.ReadLine(), out res);
            } while (!reussi || (res != choix1[0] && res != choix2[0]));
            return res;
        }
    }
}