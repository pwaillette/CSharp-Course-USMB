namespace Exo2_Carre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val = 5;
            Console.WriteLine("Carré de " + val);
            val = Program.Carre(val);
            Console.WriteLine(" => " + val);
            val = 5;
            Program.Carre(ref val);
            Console.WriteLine(" => " + val);
        }

        static void Carre(ref int val)
        {
            val = (int)Math.Pow(val, 2);
        }

        static int Carre(int val)
        {
            return (int)Math.Pow(val, 2);
        }
    }
}