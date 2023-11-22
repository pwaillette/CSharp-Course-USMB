namespace Exo6_Pythagore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double echelle, mur, recul; // Déclaration des variables

            Console.WriteLine("Echelle ?");
            echelle = double.Parse(Console.ReadLine()); // Récupération de la taille de l'échelle

            Console.WriteLine("Mur ?");
            mur = double.Parse(Console.ReadLine()); // Récupération de la hauteur du mur

            recul = Math.Round(Math.Sqrt(Math.Pow(echelle, 2) - Math.Pow(mur, 2)), 2); // Calcul du recul nécessaire

            Console.WriteLine("Recul requis : " + recul); // Affichage des résultats
        }
    }
}