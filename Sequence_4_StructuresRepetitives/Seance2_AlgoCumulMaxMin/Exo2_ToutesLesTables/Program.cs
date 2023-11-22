namespace Exo2_ToutesLesTables
{
    internal class Program
    {
        public static readonly int MIN = 1;
        public static readonly int MAX = 2;
        public static readonly int NUMBER_PER_TABLE = 10;

        static void Main(string[] args)
        {
            int table = MIN;

            int i = 0;
            int success = 0;
            Console.WriteLine("---------------------");
            while (table <= MAX)
            {
                while (i < NUMBER_PER_TABLE)
                {
                    i++;
                    Console.WriteLine("Combien font " + table + "*" + i + " ?");
                    int entry = int.Parse(Console.ReadLine());

                    if (entry != (i * table))
                    {
                        Console.WriteLine("Résultat incorrect");
                    }
                    else
                    {
                        Console.WriteLine("Résultat correct");
                        success++;
                    }
                }
                i = 0;
                table++;
            }

            Console.WriteLine("Nombre de résultat correct : " + success + "/" + MAX * NUMBER_PER_TABLE);
        }
    }
}