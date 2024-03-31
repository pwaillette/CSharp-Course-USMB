using System.Text;

namespace Partie1_UnCompte;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Bienvenue dans la gestion de comptes bancaires!");
        Console.WriteLine("Veuillez choisir le type de compte à ouvrir:");
        Console.WriteLine("1. Compte Standard");
        Console.WriteLine("2. Compte Épargne");
        Console.WriteLine("3. Compte Bloqué");
        Console.Write("Votre choix : ");
        int typeCompte = SaisieInt(1, 3);

        Compte compte;
        switch (typeCompte)
        {
            case 1:
                compte = new Compte("José", "7495547849", 142);
                break;
            case 2:
                compte = new CompteEpargne("José", "7495547849", 142);
                break;
            default:
                compte = new CompteBloque("José", "7495547849", 142);
                break;
        }

        int choix;
        do
        {
            Console.WriteLine("0. Quitter");
            Console.WriteLine("1. Créditer");
            Console.WriteLine("2. Débiter");
            Console.WriteLine("3. Consulter le solde");
            Console.WriteLine("4. Consulter les opérations");
            if (compte is CompteEpargne)
            {
                Console.WriteLine("5. Calculer les intérêts");
            }
            else if (compte is CompteBloque)
            {
                Console.WriteLine("5. Consulter le seuil minimal");
            }

            choix = SaisieInt(0, 5); 
            switch (choix)
            {
                case 0:
                    Console.WriteLine("Au revoir.");
                    break;
                case 1:
                    compte.Crediter(SaisieDoublePositif());
                    break;
                case 2:
                    compte.Debiter(SaisieDoublePositif());
                    break;
                case 3:
                    Console.WriteLine(compte.Solde);
                    break;
                case 4:
                    compte.ConsulterOpérations();
                    break;
                case 5:
                    if (compte is CompteEpargne epargne)
                    {
                        int nbAnnee = SaisieInt(1, 100);
                        Console.WriteLine($"Intérêts calculés: {epargne.CalculInteret(nbAnnee)}");
                    } else if (compte is CompteBloque bloque)
                    {
                        Console.WriteLine($"Seuil minimal: {bloque.SeuilMin}");
                    }
                    else {
                        Console.WriteLine("Option invalide.");
                    }
                    break;
                default:
                    Console.WriteLine("Entrée incorrecte.");
                    break;
            }

            Console.WriteLine("Appuyez sur une touche pour continuer...");
            Console.ReadLine();
            Console.Clear();
        } while (choix != 0);
    }

    public static decimal SaisieDoublePositif()
    {
        var saisie = Console.ReadLine();
        decimal nb;
        while (!(decimal.TryParse(saisie, out nb) && nb >= 0))
        {
            Console.WriteLine("Erreur. Nb >= 0");
            saisie = Console.ReadLine();
        }

        return nb;
    }

    public static int SaisieInt(int min, int max)
    {
        var saisie = Console.ReadLine();
        int nb;
        while (!(int.TryParse(saisie, out nb) && nb >= min && nb <= max))
        {
            Console.WriteLine($"Erreur. Nb >= {min} et nb <= {max}");
            saisie = Console.ReadLine();
        }

        return nb;
    }
}