namespace Exo3_ConversionHeureMin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h, m, nbMin = 98;
            Program.NbMinEnHeureMin(nbMin, out h, out m);
            Console.WriteLine(nbMin + " <=> " + h + ":" + m);
            TimeSpan temps = Program.NbMinEnTimeSpan(nbMin);
            Console.WriteLine(nbMin + " <=> " + temps);
        }

        static void NbMinEnHeureMin(int nbMin, out int h, out int m)
        {
            m = nbMin % 60;
            h = nbMin - m;
        }

        static TimeSpan NbMinEnTimeSpan(int nbMin)
        {
            TimeSpan timeSpam = new TimeSpan(0, nbMin, 0);
            return timeSpam;
        }

    }
}