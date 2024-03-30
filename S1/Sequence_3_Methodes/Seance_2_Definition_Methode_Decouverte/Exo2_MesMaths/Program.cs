namespace Exo2_MesMaths
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 5, b = 6;
            double moy = MesMaths.Moyenne(a, b);
            double ecart = MesMaths.Ecart(a, b);
            Console.WriteLine("Moyenne de 2 nombres : " + moy);
            Console.WriteLine("Ecart entre ces deux nombres : " + ecart);
            Console.WriteLine("Périmètre du cercle : " + MesMaths.CalculPerimetreCercle(35));
            Console.WriteLine("Conversion de degré to radian de 100 : " + MesMaths.ConvertDegreeToRadiant(100));

            Console.WriteLine(MesMaths.TireAuSort(0, 6));
            Console.WriteLine(MesMaths.TireAuSort(0, 16));
            Console.WriteLine(MesMaths.TireAuSort(0, 15));
            Console.WriteLine(MesMaths.TireAuSort(0, 15));
            Console.WriteLine(MesMaths.TireAuSort(0, 16));
            Console.WriteLine(MesMaths.TireAuSort(0, 16));
        }
    }
}