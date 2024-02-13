using Newtonsoft.Json;

namespace Exo1_List_Departements
{
    internal class Program
    {
        private static List<Departement> departements = new List<Departement>();
        static void Main(string[] args)
        {
            LoadRegion();
            int choix;
            do
            {
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine(" 0. Quitter");
                Console.WriteLine(" 1. Voir en détail un departement");
                Console.WriteLine(" 2. Voir les départements d'une région ");
                Console.WriteLine(" 3. Voir les stats: superficie et population moyenne, min et max");
                Console.WriteLine(" 4. Voir les 10 départements les plus habités ");
                Console.WriteLine(" 5. Voir les 10 départements les plus grands ");
                Console.WriteLine("----------------------------------------------");
                choix = Program.SaisieInt(0, 5);
                switch (choix)
                {
                    case 0: break;
                    case 1:
                        Console.WriteLine("Numéro du departement ?");
                        String numDep = Console.ReadLine();
                        Console.WriteLine("----------------------------------------------");
                        Departement? dpt = departements.Find(a=>a.Numero.Equals(numDep));
                        if (dpt == null) Console.WriteLine("Ce département n'existe pas !");
                        else Console.WriteLine(dpt);
                        break;
                    case 2:
                        Console.WriteLine("Nom de la région ?");
                        String nomRegion = Console.ReadLine();
                        List<Departement> dpts = departements.FindAll(a=>a.Region.Equals(nomRegion));
                        if (dpts.Count() == 0) Console.WriteLine("Cette région n'existe pas !");
                        else dpts.ForEach(dpt => Console.WriteLine(dpt.Nom));
                        break;
                    case 3: Console.WriteLine(" A FAIRE 3 "); break;
                    case 4: Console.WriteLine(" A FAIRE 4 "); break;
                    case 5: Console.WriteLine(" A FAIRE 5 "); break;
                }
                if (choix != 0)
                {
                    Console.ReadLine();
                    Console.Clear();
                }
            } while (choix != 0);
            Console.WriteLine("FIN");
        }

        private static void LoadRegion()
        {
            String path = @"data\departementsExo1.json";
            String content = File.ReadAllText(path);
            departements = JsonConvert.DeserializeObject<List<Departement>>(content);
        }

        private static int SaisieInt(int min, int max)
        {
            int nb = 0; bool ok;
            String choix = Console.ReadLine();
            do
            {
                ok = true;
                if (!(int.TryParse(choix, out nb) && nb >= min && nb <= max))
                {
                    Console.WriteLine($"Erreur- Choix entre {min} et {max} :");
                    choix = Console.ReadLine();
                    ok = false;
                }
            } while (!ok);
            return nb;
        }
    }
}