namespace Exo2_ToutesLesTables_AvecMethodes
{
    internal class Program
    {
        public static readonly int MIN = 1;
        public static readonly int MAX = 10;
        public static readonly int NUMBER_PER_TABLE = 10;

        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("REVISION DE TABLES DE MULTIPLICATIONS");
            int success = ReciteToutesLesTables();
            Console.WriteLine("Score : " +  success + "/" + MAX * NUMBER_PER_TABLE);
        }

        public static int ReciteToutesLesTables()
        {
            int success = 0;
            uint table = 1;

            while (table <= MAX)
            {
                success += ReciteUneTable(table);
                table++;
            }

            return success;
        }

        public static int ReciteUneTable(uint table)
        {
            int i = 0;
            int success = 0;
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

            return success;
        }
    }
}