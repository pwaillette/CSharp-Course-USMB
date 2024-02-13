using System.Runtime.CompilerServices;

namespace Exo2_RepeterBonjourAvecFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Bonjour !");
            }

            int nombreFois = 0;
            Console.WriteLine("Combien de bonjour ?");
            nombreFois = int.Parse(Console.ReadLine());

            for (int i = 0; i < nombreFois; i++)
            {
                Console.WriteLine("bonjour");
            }

            int a = 0;
            for (int i = 0; a != 3; i++)
            {
                if (i%3  == 0)
                {
                    Console.WriteLine(i);
                    a++;
                }
            }

            Console.WriteLine("Quel multiple ?");
            int multi = int.Parse(Console.ReadLine());

            int b = 0;
            for (int i = 0; b != 3; i++)
            {
                if (i % multi == 0)
                {
                    Console.WriteLine(i);
                    b++;
                }
            }
        }
    }
}