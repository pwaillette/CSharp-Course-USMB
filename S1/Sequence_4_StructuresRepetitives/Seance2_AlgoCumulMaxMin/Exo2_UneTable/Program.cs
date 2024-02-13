namespace Exo2_UneTable
{
    internal class Program
    {
        public static readonly int MIN = 1;
        public static readonly int MAX = 10;

        static void Main(string[] args)
        {
            Console.WriteLine("Entrez la table :");
            int table = int.Parse(Console.ReadLine());

            int i = 0;
            int success = 0;
            Console.WriteLine("---------------------");
            while (i < MAX)
            {
                i++;
                Console.WriteLine("Combien font " + table + "*" +  i + " ?");
                int entry = int.Parse(Console.ReadLine());

                if (entry != (i * table))
                {
                    Console.WriteLine("Résultat incorrect");
                } else
                {
                    Console.WriteLine("Résultat correct");
                    success++;
                }
            }

            Console.WriteLine("Nombre de résultat correct : " + success + "/" + MAX);
        }
    }
}