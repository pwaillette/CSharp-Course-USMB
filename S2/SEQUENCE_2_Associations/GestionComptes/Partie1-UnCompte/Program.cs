using System.Text;

namespace Partie1_UnCompte;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        var c = new Compte();
        int choix;
        do
        {
            Console.WriteLine("0.Quitter");
            Console.WriteLine("1.Créditer");
            Console.WriteLine("2.Débiter");
            Console.WriteLine("3.Consulter le solde");
            choix = SaisieInt(0, 3);
            switch (choix)
            {
                case 0:
                    Console.WriteLine("Au revoir.");
                    break;
                case 1:
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("CREDITER :");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Montant à crediter :");
                    var mont = SaisieDoublePositif();
                    c.Crediter(mont);
                    break;
                }
                case 2:
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("DEBITER :");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("Montant à débiter :");
                    var mt = SaisieDoublePositif();
                    c.Debiter(mt);
                    break;
                }
                case 3:
                {
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("CONSULTER LE SOLDE :");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine(c.Solde);
                    break;
                }
            }

            Console.WriteLine("appuyez sur une touche...");
            Console.ReadLine();
            Console.Clear();
        } while (choix != 0);
    }

    public static double SaisieDoublePositif()
    {
        var saisie = Console.ReadLine();
        double nb;
        while (!(double.TryParse(saisie, out nb) && nb >= 0))
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