namespace Exo4_Min
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nb1 = GetNumber(1), nb2 = GetNumber(2), nb3 = GetNumber(3);

            // Récupérer le nombre le plus petit
            if (nb1 < nb2 && nb1 < nb3)
            {
                Console.WriteLine(nb1 + " Nombre 1");
            }
            else if (nb2 < nb3)
            {
                Console.WriteLine(nb2 + " Nombre 2");
            } else 
                Console.WriteLine(nb3 + " Nombre 3");
        }

        static int GetNumber(int num)
        {
            Console.WriteLine("Numéro " + num + " ?");
            return int.Parse(Console.ReadLine());
        }
    }
}