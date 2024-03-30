namespace Exo3_JeuDeDes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.nbDe(5, 1));
            Console.WriteLine(Program.nbDe(6, 3));
        }

        public static int lanceUnDe()
        {
            return new Random().Next(1, 6);
        }

        public static int nbDe(int nbLances, int nb)
        {
            int nbDeNb = 0;
            for (int i = 0; i < nbLances; i++)
            {
                nbDeNb += (lanceUnDe() == nb) ? 1 : 0;
            }

            return nbDeNb;
        }
    }
}