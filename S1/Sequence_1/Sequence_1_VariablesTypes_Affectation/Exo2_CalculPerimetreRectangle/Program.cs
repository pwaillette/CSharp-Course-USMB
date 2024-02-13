namespace Exo2_CalculPerimetreRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double largeur, hauteur, perimetre;
            string unite;

            Console.WriteLine("CALCUL DU PERIMETRE D'UN RECTANGLE");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Unité de mesure (mm, cm, m ...) :");
            unite = Console.ReadLine();

            Console.WriteLine("Largeur : ");
            largeur = double.Parse(Console.ReadLine());

            Console.WriteLine("Hauteur : ");
            hauteur = double.Parse(Console.ReadLine());

            perimetre = (largeur + hauteur) * 2;
            Console.WriteLine("Périmètre du carré : " + perimetre + " " + unite);
        }
    }
}