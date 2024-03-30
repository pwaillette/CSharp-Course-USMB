namespace Exo1_OperationsElementaires
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val1, val2;

            Console.WriteLine("val1 ?");
            val1 = int.Parse(Console.ReadLine()); // Récupération de la première valeur

            Console.WriteLine("val2 ?");
            val2 = int.Parse(Console.ReadLine()); // Récupération de la deuxième valeur

            Console.WriteLine("val1 + val2 = " + val1 + val2); // Calcul de l'addition
            Console.WriteLine("val1 + val2 = " + (val1 + val2)); // Calcul de l'addition
            Console.WriteLine("val1 - val2 = " + (val1 - val2)); // Calcul de la soustraction 
            Console.WriteLine("val1 * val2 = " + (val1 * val2)); // Calcul de la multiplication
            Console.WriteLine("val1 / val2 = " + (val1 / val2)); // Calcul de la division
            Console.WriteLine("val1 / val2 = " + ((double)val1 / val2)); // Calcul de la division
            Console.WriteLine("val1 % val2 = " + (val1 % val2)); // Calcul du modulo
        }
    }
}