namespace Exo_AlgoClassiquesMethodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = 0, max = 0;
            double moyenne = 0;
            int[]? tab = null;
            bool existe = false;
            tab = Program.InitTableau(
4, 1, 100);
            Console.WriteLine("----------------------------");
            Console.WriteLine("Min, max, moyenne ");
            Console.WriteLine("----------------------------");
            Program.Affiche(tab);
            Console.WriteLine("----------------------------");
            max = Program.Max(tab);
            Console.WriteLine("Max : " + max);
            min = Program.Min(tab);
            Console.WriteLine("Min : " + min);
            moyenne = Program.Moyenne(tab);
            Console.WriteLine("Moyenne : " + moyenne);
            Console.WriteLine("----------------------------");
            Console.WriteLine("Inverse ");
            Console.WriteLine("----------------------------");
            Program.Affiche(tab);
            Program.Inverse(tab);
            Program.Affiche(tab);
            tab = new int[] { 10, 20, 30, 40 };
            Console.WriteLine("----------------------------");
            Console.WriteLine("Recherche ");
            Console.WriteLine("----------------------------");
            Program.Affiche(tab);
            Console.WriteLine("----------------------------");
            existe = Program.Existe(20,tab);
            Console.WriteLine("20 existe : " + existe);
            existe = Program.Existe(99, tab);
            Console.WriteLine("19 existe : " + existe);
            Program.Inverse(tab);
        }

        public static int[] InitTableau(int nbValeur)
        {
            int[] array = new int[nbValeur];

            for (int i = 0; i< nbValeur; i++)
            {
                array[i] = new Random().Next(0, 1000000000);
            }

            return array;
        }

        public static int[] InitTableau(int nbValeur, int min, int max)
        {
            int[] array = new int[nbValeur];
            array[0] = min;

            for (int i = 1; i< nbValeur - 1; i++)
            {
                array[i] = new Random().Next(min, max);
            }
            array[nbValeur - 1] = max;
            return array;
        }

        public static void Affiche(int[] array)
        {
            string str = "";

            for (int i = 0; i < array.Length; i++)
            {
                str += array[i].ToString();
                str += "    ";
            }

            Console.WriteLine(str);
        }

        public static int Max(int[] array)
        {
            int max = 0;
            for (int i = 0;i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
            }

            return max;
        }

        public static int Min(int[] array)
        {
            int min = 1000000000;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
            }

            return min;
        }

        public static double Moyenne(int[] array)
        {
            double sum = 0;
            int size = array.Length;

            for (int i = 0; i < size; i++)
            {
                sum += array[i];
            }

            return Math.Round(sum / size, 1);
        }

        public static int[] Inverse(int[] array)
        {
            int length = array.Length;
            for (int i = 0; i < length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[length - 1 - i];
                array[length - 1 - i] = temp;
            }

            return array;
        }

        public static bool Existe(int num, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num) return true;
            }

            return false;
        }
    }
}