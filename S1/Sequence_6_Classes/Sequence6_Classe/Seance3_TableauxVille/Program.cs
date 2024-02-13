namespace Seance3_TableauxVille
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ville[] lesVilles = new Ville[4];
            lesVilles[0] = new Ville("74000", "Annecy", 128199, 66.93);
            lesVilles[1] = new Ville("74200", "Thonon", 35241, 16.21);
            lesVilles[2] = new Ville("73000", "Chambery", 58833, 20.99);
            lesVilles[3] = new Ville("73200", "Albertville", 19214, 17.54);

            while (true)
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine(" MENU");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("0.quitter");
                Console.WriteLine("1.Afficher toutes les villes");
                Console.WriteLine("2.Afficher les villes d’un département ");
                Console.WriteLine("3.Afficher une ville ");
                Console.WriteLine("4.Voir la plus grande ville");
                Console.WriteLine("5.Voir la ville la plus dense");
                Console.WriteLine("6.Voir la ville à la plus grande superficie");
                Console.WriteLine("7.Afficher le nombre total d’habitants");
                Console.WriteLine("8.Afficher la densité moyenne");

                int choix = SaisieNb(0, 8);

                if (choix == 0)
                    break;

                switch (choix)
                {
                    case 1:
                        Affiche(lesVilles);
                        break;
                    case 2:
                        Console.WriteLine("Entrez un département : (1-95)");
                        int dep = SaisieNb(1, 95);
                        Affiche(lesVilles, dep);
                        break;
                    case 3:
                        Console.WriteLine("Entrez le nom de la ville");
                        string nom = Console.ReadLine();
                        AfficheUneVille(lesVilles, nom);
                        break;
                    case 4:
                        AfficheLaVilleLaPlusGrande(lesVilles);
                        break;
                    case 5:
                        AfficheLaVilleLaPlusDense(lesVilles);
                        break;
                    case 6:
                        AfficheLaVilleALaPlusGrandeSuperficie(lesVilles);
                        break;
                    case 7:
                        AfficheNombreTotalHabitants(lesVilles);
                        break;
                    case 8:
                        AfficheDensiteMoyenne(lesVilles);
                        break;
                }

                Console.ReadLine();
            }
        }

        // Méthodes à compléter

        public static void Affiche(Ville[] villes)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("TOUTES LES VILLES");
            foreach (Ville ville in villes)
            {
                Console.WriteLine(ville);
            }
        }

        public static void Affiche(Ville[] villes, int departement)
        {
            Console.WriteLine($"---------------------------------");
            Console.WriteLine($"VILLES DU DÉPARTEMENT {departement}");
            bool aucuneVille = true;

            foreach (Ville ville in villes)
            {
                if (ville.CodePostal.StartsWith(departement.ToString()))
                {
                    aucuneVille = false;
                    Console.WriteLine(ville);
                }
            }

            if (aucuneVille)
            {
                Console.WriteLine($"Aucune ville pour le département {departement}");
            }
        }

        public static void AfficheUneVille(Ville[] villes, string nomVille)
        {
            Console.WriteLine($"---------------------------------");
            Console.WriteLine($"VILLE : {nomVille}");

            bool villeTrouvee = false;

            foreach (Ville ville in villes)
            {
                if (ville.Nom.Equals(nomVille, StringComparison.OrdinalIgnoreCase))
                {
                    villeTrouvee = true;
                    Console.WriteLine(ville);
                    break;
                }
            }

            if (!villeTrouvee)
            {
                Console.WriteLine($"Ville non trouvée : {nomVille}");
            }
        }

        public static void AfficheLaVilleLaPlusGrande(Ville[] villes)
        {
            Console.WriteLine($"---------------------------------");
            Console.WriteLine("VILLE LA PLUS GRANDE");

            Ville villePlusGrande = villes[0];

            for (int i = 1; i < villes.Length; i++)
            {
                if (villes[i].Superficie > villePlusGrande.Superficie)
                {
                    villePlusGrande = villes[i];
                }
            }

            Console.WriteLine(villePlusGrande);
        }

        public static void AfficheLaVilleLaPlusDense(Ville[] villes)
        {
            Console.WriteLine($"---------------------------------");
            Console.WriteLine("VILLE LA PLUS DENSE");

            Ville villePlusDense = villes[0];

            for (int i = 1; i < villes.Length; i++)
            {
                if (villes[i].Densite > villePlusDense.Densite)
                {
                    villePlusDense = villes[i];
                }
            }

            Console.WriteLine(villePlusDense);
        }

        public static void AfficheLaVilleALaPlusGrandeSuperficie(Ville[] villes)
        {
            Console.WriteLine($"---------------------------------");
            Console.WriteLine("VILLE À LA PLUS GRANDE SUPERFICIE");

            Ville villePlusGrandeSuperficie = villes[0];

            for (int i = 1; i < villes.Length; i++)
            {
                if (villes[i].Superficie > villePlusGrandeSuperficie.Superficie)
                {
                    villePlusGrandeSuperficie = villes[i];
                }
            }

            Console.WriteLine(villePlusGrandeSuperficie);
        }

        public static void AfficheNombreTotalHabitants(Ville[] villes)
        {
            Console.WriteLine($"---------------------------------");
            Console.WriteLine("NOMBRE TOTAL D'HABITANTS");

            int totalHabitants = 0;

            foreach (Ville ville in villes)
            {
                totalHabitants += ville.NbHabitants;
            }

            Console.WriteLine($"Le nombre total d'habitants est de : {totalHabitants}");
        }

        public static void AfficheDensiteMoyenne(Ville[] villes)
        {
            Console.WriteLine($"---------------------------------");
            Console.WriteLine("DENSITÉ MOYENNE");

            double totalDensite = 0;

            foreach (Ville ville in villes)
            {
                totalDensite += ville.Densite;
            }

            double densiteMoyenne = totalDensite / villes.Length;

            Console.WriteLine($"La densité moyenne est de : {densiteMoyenne:F2}");
        }

        public static int SaisieNb(int min, int max)
        {
            string saisie = Console.ReadLine();
            int nb;
            while (!(int.TryParse(saisie, out nb) && nb >= min && nb <= max))
            {
                Console.WriteLine("Erreur de saisie.");
                Console.WriteLine($"Choix compris entre {min} et {max}:");
                saisie = Console.ReadLine();
            }
            return nb;
        }
    }
}