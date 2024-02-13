using Newtonsoft.Json;
using System.Xml;

namespace CabinetMedical
{
    internal class Program
    {
        private static List<Consultation> consultations = ChargeJson<Consultation>("lesConsultations.json");

        static void Main(string[] args)
        {

            int choix;

            do
            {
                AfficherMenu();
                choix = LireEntier("Veuillez choisir une option : ");

                switch (choix)
                {
                    case 1:
                        VoirToutesConsultations();
                        break;
                    case 2:
                        AjouterConsultation();
                        break;
                    case 3:
                        VoirConsultationsDuJour();
                        break;
                    case 4:
                        VoirConsultationsDocteur();
                        break;
                    case 5:
                        VoirConsultationsTrieesParDate();
                        break;
                    case 6:
                        VoirConsultationsTrieesParPrix();
                        break;
                    case 7:
                        VoirConsultationsTrieesParDocteur();
                        break;
                    case 0:
                        SauvegarderConsultations();
                        break;
                    default:
                        Console.WriteLine("Option non valide. Veuillez choisir une option valide.");
                        break;
                }
                SauvegardeJson<Consultation>(consultations, "lesConsultations.json");
            } while (choix != 0);
        }

        static void AfficherMenu()
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("0. Quitter et sauvegarder");
            Console.WriteLine("1. Voir toutes consultations");
            Console.WriteLine("2. Ajouter une consultation");
            Console.WriteLine("3. Voir les consultations du jour");
            Console.WriteLine("4. Voir les Consultations d’un docteur");
            Console.WriteLine("5. Voir les Consultations Triées par date");
            Console.WriteLine("6. Voir les Consultations Triées par prix");
            Console.WriteLine("7. Voir les Consultations Triées par docteur");
            Console.WriteLine("------------------------------------------------");
        }

        static void VoirToutesConsultations()
        {
            Console.WriteLine("Liste de toutes les consultations :");
            foreach (var consultation in consultations)
            {
                Console.WriteLine($"- {consultation}");
            }
        }

        static void AjouterConsultation()
        {
            // à créer
        }

        static void VoirConsultationsDuJour()
        {
            DateTime aujourdHui = DateTime.Today;

            Console.WriteLine($"Consultations du {aujourdHui.ToShortDateString()} :");
            foreach (var consultation in consultations.Where(c => c.UnJourUnHoraire.Date == aujourdHui.Date))
            {
                Console.WriteLine($"- {consultation}");
            }
        }

        static void VoirConsultationsDocteur()
        {
            // à créer
        }

        static void VoirConsultationsTrieesParDate()
        {
            Console.WriteLine("Consultations triées par date :");
            foreach (var consultation in consultations.OrderBy(c => c.UnJourUnHoraire))
            {
                Console.WriteLine($"- {consultation}");
            }
        }

        static void VoirConsultationsTrieesParPrix()
        {
            Console.WriteLine("Consultations triées par prix :");
            foreach (var consultation in consultations.OrderBy(c => c.CalculPrixConsultation()))
            {
                Console.WriteLine($"- {consultation}");
            }
        }

        static void VoirConsultationsTrieesParDocteur()
        {
            Console.WriteLine("Consultations triées par docteur :");
            foreach (var consultation in consultations.OrderBy(c => c.UnDocteur.UnNom))
            {
                Console.WriteLine($"- {consultation}");
            }
        }

        static void SauvegarderConsultations()
        {
            // à créer
        }

        static int LireEntier(string message)
        {
            int resultat;
            while (true)
            {
                Console.Write(message);
                if (int.TryParse(Console.ReadLine(), out resultat))
                {
                    return resultat;
                }
                else
                {
                    Console.WriteLine("Veuillez entrer un nombre entier valide.");
                }
            }
        }

        private static string LireString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }



        private static List<T> ChargeJson<T>(String pathName)
        {
            List<T> liste = null;
            try
            {
                String contenuFichier = File.ReadAllText(pathName);
                liste = JsonConvert.DeserializeObject<List<T>>(contenuFichier);
            }
            catch (Exception e) { throw; }
            return liste;
        }
        private static void SauvegardeJson<T>(List<T> liste, String pathName)
        {
            try
            {
                string result = JsonConvert.SerializeObject(liste, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(pathName, result);
            }
            catch (Exception e) { throw; }
        }
    }
}