namespace Exo2_Factorielle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.factorielle(5));
        }

        public static int factorielle(int nb)
        {
            if (nb < 0) throw new ArgumentOutOfRangeException("Le nombre ne peut pas être inférieur à 0");

            return nb > 1 ? nb * factorielle(nb - 1) : 1;
        }
    }
}