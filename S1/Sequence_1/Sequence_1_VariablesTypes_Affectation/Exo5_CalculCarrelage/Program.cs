namespace Exo5_CalculCarrelage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dimensionLongueurSolMetre, dimensionLargeurSolMetre, dimensionLongueurCarreauCm, dimensionLargeurCarreauCm, dimensionCarreau, dimensionSol, nbCarreaux, nbPaquet;
            int nbCarreauxParPaquet;

            Console.WriteLine("CALCUL DES PAQUETS DE CARRELAGE");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Longueur du sol (m) :");
            dimensionLongueurSolMetre = double.Parse(Console.ReadLine());
            Console.WriteLine("Largeur du sol (m) :");
            dimensionLargeurSolMetre = double.Parse(Console.ReadLine());
            Console.WriteLine("Longueur du carreau (cm) : ");
            dimensionLongueurCarreauCm = double.Parse(Console.ReadLine());
            Console.WriteLine("Largeur du carreau (cm) : ");
            dimensionLargeurCarreauCm = double.Parse(Console.ReadLine());
            Console.WriteLine("Nombre de carreaux par paquet : ");
            nbCarreauxParPaquet = int.Parse(Console.ReadLine());

            dimensionCarreau = dimensionLargeurCarreauCm * dimensionLongueurCarreauCm;
            dimensionSol = dimensionLargeurSolMetre * dimensionLongueurSolMetre;
            nbCarreaux = Math.Ceiling(dimensionSol / ((dimensionCarreau) / 10000));
            nbPaquet = Math.Ceiling(nbCarreaux / nbCarreauxParPaquet);
            Console.WriteLine(nbPaquet);

        }
    }
}