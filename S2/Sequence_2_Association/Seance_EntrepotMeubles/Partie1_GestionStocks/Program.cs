using Newtonsoft.Json;
using System.Text.Json;

namespace Partie1_GestionStocks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String pathName = "stocks.json";
            List<Stock> lesStocks = null;
            bool encore = true;
            try
            {
                lesStocks = Program.Charge<Stock>(pathName);
            }
            catch (Exception e)
            {
                Console.WriteLine("Probleme lors du chargement des stocks ");
                Console.WriteLine(e);
                Environment.Exit(2);
            }
            while (encore)
            {
                Console.Clear();
                Console.WriteLine("---------------------");
                Console.WriteLine("0.Quitter");
                Console.WriteLine("1.Voir tous les stocks");
                Console.WriteLine("2.Voir les stocks épuisés ");
                Console.WriteLine("3.Info stocks : montant et volume ");
                Console.WriteLine("4.Voir/modifier un stock ");
                Console.WriteLine("---------------------");
                int rep = SaisieInt(0, 4);
                switch (rep)
                {
                    case 0: encore = false; break;
                    case 1:
                        {
                            foreach (Stock stock in lesStocks)
                            {
                                Console.WriteLine("---------------------");
                                Console.WriteLine(stock);
                                Console.WriteLine("---------------------");
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("---------------------");
                            Console.WriteLine("TOUS LES STOCKS ÉPUISÉS");
                            Console.WriteLine("---------------------");
                            AfficheStocksEpuises(lesStocks);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("---------------------");
                            Console.WriteLine("TOUS LES STOCKS");
                            Console.WriteLine("---------------------");
                            AfficheListe(lesStocks);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Quel est la référence du meuble ?");
                            String refMeuble = Console.ReadLine();
                            Console.WriteLine("Voulez-vous le voir, ou le modifier ? (v/m)");
                            String optionInput = Console.ReadLine();

                            if (String.IsNullOrEmpty(optionInput) || (!optionInput.Equals("v") && !optionInput.Equals("m"))) {
                                Console.WriteLine("Veuillez entrer une option valide (v/m)");
                                break;
                            } 
                            else
                            {
                                Stock s = lesStocks.Find(a=>a.LeMeuble.LaReference == refMeuble);
                                if (s == null)
                                {
                                    Console.WriteLine("Stock non trouvé, veuillez vérifier la référence entrée.");
                                    break;
                                }

                                if (optionInput == "v") Console.WriteLine(s.ToString());
                                else
                                {
                                    Console.WriteLine("Voulez-vous ajouter ou retirer ? (a/r)");
                                    String ajoutOuRetrait = Console.ReadLine();
                                    Console.WriteLine("Quelle quantité ?");
                                    int quantity = int.Parse(Console.ReadLine());
                                    if (ajoutOuRetrait == "a") s.AjouteStock(quantity);
                                    else if (ajoutOuRetrait == "r") s.RetireStock(quantity);
                                    else { Console.WriteLine("Option non reconnue, a/r"); break; }
                                }
                            }
                            break;
                        }
                }
                // pour faire une pause avant le clear
                Console.ReadLine();
            }
            Ecriture(lesStocks, pathName);
        }

        public static void AfficheStocksEpuises(List<Stock> liste)
        {
            List<Stock> bakaUwu = liste.FindAll(a=>a.LaQuantite==0);
            if (bakaUwu.Count == 0) Console.WriteLine("Aucun stock n'est vide");
            else AfficheListe(bakaUwu);
        }

        public static int SaisieInt(int min, int max)
        {
            bool nice = false;
            int machin = 0;
            while (!nice)
            {
                nice = int.TryParse(Console.ReadLine(), out machin);

                if (nice)
                {
                    if (machin < min || machin > max) nice = false;
                }
            }
            return machin;
        }

        public static void AfficheListe(List<Stock> liste)
        {
            double montantTotal = 0;
            double volumeTotal = 0;
            foreach (Stock unStock in liste)
            {
                Console.WriteLine(unStock.FormatPrix());
                montantTotal = unStock.LaQuantite * unStock.LeMeuble.LePrix;
            }
            Console.WriteLine("---------------------");
            Console.WriteLine($"Montant total: {montantTotal} {Meuble.MONNAIE}");
            Console.WriteLine("---------------------");

            foreach(Stock unStock in liste)
            {
                volumeTotal += ((unStock.LaQuantite * unStock.LeMeuble.LaDimension.Volume()) / 1000000);
                Console.WriteLine(unStock.FormatVolume());
            }
            Console.WriteLine("---------------------");
            Console.WriteLine($"Volume total: {volumeTotal} {Dimension.UNITE_VOLUME}");
            Console.WriteLine("---------------------");
        }

        private static List<T> Charge<T>(String pathName)
        {
            List<T> lesInfos = null;
            try
            {
                String contenuFichier = File.ReadAllText(pathName);
                lesInfos = JsonConvert.DeserializeObject<List<T>>(contenuFichier);
            }
            catch (Exception e) { throw e; } //on relance l'exception
                                             //à celui qui appelle la méthode : ici le main pour
                                             // qu'il décide de l'action à faire
            return lesInfos;
        }

        public static void Ecriture(object obj, string fileName)
        {
            var options = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            var jsonString = System.Text.Json.JsonSerializer.Serialize(obj, options);
            File.WriteAllText(fileName, jsonString);
        }
    }
}