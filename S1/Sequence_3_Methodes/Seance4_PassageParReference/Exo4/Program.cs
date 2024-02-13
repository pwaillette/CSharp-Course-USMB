namespace Exo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan temps = new TimeSpan(11, 44, 59);
            Console.WriteLine(temps);
            Program.PlusUneSeconde(ref temps);
            Console.WriteLine(temps);
            Program.PlusUneSeconde(ref temps);
            Console.WriteLine(temps);
        }

        private static void PlusUneSeconde(ref TimeSpan temps)
        {
            temps = temps.Add(new TimeSpan(0, 0, 1));
        }
    }
}