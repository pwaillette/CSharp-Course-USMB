namespace Exo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 3;
            Console.WriteLine("a = " + a + " b = " + b);
            Program.Echange(ref a, ref b);
            Console.WriteLine("a = " + a + " b = " + b);
        }
        public static void Echange(ref int a, ref int b)
        {
            int tmp = b;
            b = a;
            a = tmp;
        }

    }
}