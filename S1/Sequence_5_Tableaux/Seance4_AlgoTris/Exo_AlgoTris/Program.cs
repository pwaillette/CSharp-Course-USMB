namespace Exo_AlgoTris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[] { 5, 10, 4, 2, 8, 9 };
            Program.Affiche(tab);
            tab = TriBulle(tab);
            Program.Affiche(tab);
        }
        public static void Affiche(int[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
                Console.Write(tab[i] + " ");
            Console.WriteLine();
        }

        public static int[] TriBulle(int[] tab)
        {
            for (int i=0; i<tab.Length; i++)
            {
                for (int j=i+1; j<tab.Length; j++)
                {
                    if (tab[i] > tab[j])
                    {
                        int tmp = tab[i];
                        tab[i] = tab[j];
                        tab[j] = tmp;
                    }
                }
            }

            return tab;
        }
    }
}