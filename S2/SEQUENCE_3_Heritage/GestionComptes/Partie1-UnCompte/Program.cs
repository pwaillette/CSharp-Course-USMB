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

        Compte compte = null;  // Compte is a placeholder for your base class or interface
        switch (typeCompte)
        {
            case 1:
                // Ici, instanciez votre Compte standard avec les informations nécessaires
                // compte = new Compte("Nom", "Numéro", SoldeInitial);
                break;
            case 2:
                // Ici, remplacez par un objet de classe CompteEpargne
                compte = new CompteEpargne("José", "7495547849", 142);
                break;
            case 3:
                // Ici, remplacez par un objet de classe CompteBloque
                // compte = new CompteBloque("Nom", "Numéro", SoldeInitial);
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
                // Ajouter ici d'autres options spécifiques au Compte Épargne
            }
            // Si votre Compte Bloqué a des options spécifiques, ajoutez-les ici de manière similaire.
            

            choix = SaisieInt(0, 5); // Assurez-vous de modifier le deuxième paramètre en fonction des options disponibles
            switch (choix)
            {
                case 0:
                    Console.WriteLine("Au revoir.");
                    break;
                case 1:
                    // Code pour créditer
                    
                    break;
                case 2:
                    // Code pour débiter
                    break;
                case 3:
                    // Code pour consulter le solde
                    break;
                case 4:
                    // Code pour consulter les opérations
                    break;
                case 5:
                    if (compte is CompteEpargne epargne)
                    {
                        // Supposons que vous avez une méthode pour calculer les intérêts
                        // double interets = epargne.CalculInteret(...);
                        // Console.WriteLine($"Intérêts calculés: {interets}");
                    } else {
                        Console.WriteLine("Option invalide.");
                    }
                    break;
                // Ajoutez d'autres cases ici pour d'autres fonctionnalités spécifiques
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