using VerifSaisies;

namespace Exo2_Utilisation_Verif_Saisies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char statut = Saisie.SaisieUnCaracParmiDeuxChoix("Entrez votre catégorie", "C", "O");
            string stat = (statut == 'C') ? "C" : "Ouvrier";
            Console.WriteLine("Nombre d'enfant ?");
            double nbChild = Saisie.SaisieDoublePositif(0, 20);

            if (nbChild > 0) Console.WriteLine($"L'employé Dupont est un {stat} ayant {nbChild} enfant(s)");
            else Console.WriteLine($"L'employé Rabah est un {stat} n'ayant pas d'enfant");
        }
    }
}