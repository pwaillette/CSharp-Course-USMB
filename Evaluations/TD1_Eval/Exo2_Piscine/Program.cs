namespace Exo2_Piscine
{
    internal class Program
    {
        public static readonly string[] ABONNEMENT_TYPES = {"A", "E"};
        public static readonly string[] ABONNEMENT_DETAILS = { "A", "S" };
        public static readonly string ABONNEMENT = "A";
        public static readonly string[] ANSWERS_REDUCTION_CARD = { "O", "N" };
        public const int MIN_ADULT_AGE = 25;
        public const int MAX_ADULT_AGE = 65;
        public const double ABO_SEMESTRIEL_ADULT = 85;
        public const double ABO_SEMESTRIEL_REDUCED = 63.80;
        public const double ABO_ANNUEL_ADULT = 155.8;
        public const double ABO_ANNUEL_REDUCED = 116.9;
        public const double ENTER_ADULT = 4.8;
        public const double ENTER_REDCUED = 3.6;
        public const double REDUCTION_CARD_EFFECT = 0.1;

        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------");
            Console.WriteLine("CAISSE PISCINE");
            Console.WriteLine("---------------------------------");

            string typeAbonnement = GetTypeAbonnement();

            Console.WriteLine("---------------------------------");

            int age = GetAge();
            double prixEntree = 0;

            if (typeAbonnement == ABONNEMENT)
            {
                prixEntree = CalculePrixAbonnement(typeAbonnement, age);
            }
            else {
                bool carteEntree = GetReductionCard();
                prixEntree = CalculePrixEntree(carteEntree, age);
            }

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Prix de l'entrée : " + prixEntree + " euro(s)");
        }

        public static double CalculePrixEntree(bool carteEntree, int age)
        {
            bool isReducedTarif = false;
            double tarif = 0;

            // Si l'âge est supérieur à 65 ans ou inférieur ou égal à 25 ans, c'est un tarif réduit
            if (age <= MIN_ADULT_AGE || age > MAX_ADULT_AGE) isReducedTarif = true;
            tarif = (isReducedTarif) ? ENTER_REDCUED : ENTER_ADULT; // Renvoi du tarif d'entrée réduit ou non en fonction de l'âge

            // Renvoie le tarif moins la réduction si il y a la carte, sinon le tarif plein
            return (carteEntree) ? tarif - (tarif * REDUCTION_CARD_EFFECT) : tarif;
        }

        public static double CalculePrixAbonnement(String typeAbonnement, int age)
        {
            bool isReducedTarif = false;

            // Si l'âge est supérieur à 65 ans ou inférieur ou égal à 25 ans, c'est un tarif réduit
            if (age <= MIN_ADULT_AGE || age > MAX_ADULT_AGE) isReducedTarif = true;
            string abonnementDetails = "";

            // Récupération du type d'abonnement
            abonnementDetails = GetAbonnementDetails();

            //Si c'est un abonnement annuel, renvoyer le tarif réduit ou non en fonction de l'âge du client, sinon renvoyer le tarif réduit ou non d'un abonnement semestriel
            if (abonnementDetails == "A") return (isReducedTarif) ? ABO_ANNUEL_REDUCED : ABO_ANNUEL_ADULT;
            else return (isReducedTarif) ? ABO_SEMESTRIEL_REDUCED : ABO_SEMESTRIEL_ADULT;
        }

        public static string GetTypeAbonnement()
        {
            string typeAbonnement = "";

            // Demande le type d'abonnement (A ou E) tant que celui entré par l'utilisateur ne correspond pas aux formats acceptés
            do
            {
                Console.WriteLine("Abonnement ou Entree (A/E) ?");
                typeAbonnement = Console.ReadLine();
            } while (string.IsNullOrEmpty(typeAbonnement) || !ABONNEMENT_TYPES.Contains(typeAbonnement));

            return typeAbonnement;
        }

        public static string GetAbonnementDetails()
        {
            string typeAbonnementDetails = "";

            // Récupération du type d'abonnement (Annuel/Semestriel) tant que l'entrée utilisateur est incorrecte
            do
            {
                Console.WriteLine("Type abonnement : Annuel ou Semestriel (A/S) ?");
                typeAbonnementDetails = Console.ReadLine();
            } while (string.IsNullOrEmpty(typeAbonnementDetails) || !ABONNEMENT_DETAILS.Contains(typeAbonnementDetails));

            return typeAbonnementDetails;
        }

        public static bool GetReductionCard()
        {
            string reductionCard = "";

            // Demande si l'utilisateur possède la carte de réduction (O/N) tant que la réponse de l'utilisateur n'est pas dans le format correct
            do
            {
                Console.WriteLine("Carte de réduction (O/N) ?");
                reductionCard = Console.ReadLine();
            } while (String.IsNullOrEmpty(reductionCard) || !ANSWERS_REDUCTION_CARD.Contains(reductionCard));

            // Renvoie true (l'utilisateur possède sa carte de réduction) si l'entrée utilisateur est O (Oui), sinon false car l'entrée sera N (Non)
            return (reductionCard == "O") ? true : false;
        }

        public static int GetAge()
        {
            int age = 0;
            bool isInt = false;

            // Boucle pour redemander l'âge de la personne tant que celui-ci n'est pas correct
            do
            {
                Console.WriteLine("Age ?");
                isInt = int.TryParse(Console.ReadLine(), out age);
            } while (!isInt);

            return age;
        }
    }
}