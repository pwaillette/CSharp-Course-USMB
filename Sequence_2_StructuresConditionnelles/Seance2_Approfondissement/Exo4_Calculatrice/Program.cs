namespace Exo4_Calculatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintMenu();

            string operand = GetOperation();
            double nombre1 = GetNumber(1), nombre2 = GetNumber(2);
            double result;

            result = operand switch
            {
                "+" => nombre1 + nombre2,
                "-" => nombre1 - nombre2,
                "*" => nombre1 * nombre2,
                "/" => nombre1 / nombre2,
                _ => 0
            };

            Console.WriteLine("Opération : " + nombre1 + " " + operand + " " + nombre2 + "\nRésultat : " + result);
        }

        static void PrintMenu()
        {
            Console.WriteLine("----------------------------------\n"
                            + "MENU\n"
                            + "----------------------------------\n"
                            + "+ pour additionner\n"
                            + "- pour soustraire\n"
                            + "* pour multiplier\n"
                            + "/ pour diviser\n"
                            + "----------------------------------");
        }

        static double GetNumber(int num)
        {
            Console.WriteLine("Entrez le nombre numéro " + num + " :");
            return double.Parse(Console.ReadLine());
        }

        static string GetOperation()
        {
            Console.WriteLine("Saisissez l'opérateur (l'opération à faire) : ");
            return Console.ReadLine();
        }
    }
}