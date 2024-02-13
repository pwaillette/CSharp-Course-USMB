namespace Exo3_JeuDeDevinette
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Partie 1
            int rand = new Random().Next(1, 10);
            int i = 0;
            string enter = "";

            do
            {
                if (enter != "")
                {
                    Console.WriteLine("Raté !");
                }
                Console.WriteLine("Essaye de deviner le nombre !");
                enter = Console.ReadLine();
                i++;
            } while (int.Parse(enter) != rand);

            Console.WriteLine("Gagné ! Le nombre était bien : " + i + ". Tu as réussi en " + (i+1) + " essais");*/

            int rand = new Random().Next(1, 10);
            bool replay = false;

            do
            {
                int i = 0;
                string enter = "";
                do
                {
                    if (i == 5) break;
                    if (enter != "")
                    {
                        Console.WriteLine("Raté !");
                    }
                    Console.WriteLine("Essaye de deviner le nombre !");
                    enter = Console.ReadLine();
                    i++;
                } while (int.Parse(enter) != rand);

                if (int.Parse(enter) == rand)
                {
                    Console.WriteLine("Gagné ! Le nombre était bien : " + rand + ". Tu as réussi en " + i + " essais");
                }
                else
                {
                    Console.WriteLine("Perdu ! 5 essais maximum !");
                }

                Console.WriteLine("Tu veux rejouer ? (O/N)");
                replay = (Console.ReadLine() == "O") ? true : false;
            } while (replay);
        }
    }
}