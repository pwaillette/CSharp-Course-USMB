namespace Exo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test();
        }

        private static void Test()
        {
            Voiture vielleThermique = new Voiture("AZ-123-RT", "3008", "Peugeot", Voiture.CAT_THERMIQUE, 2010, 82, 135);
            Console.WriteLine(vielleThermique);
            Console.WriteLine("Puissance fiscale : " + vielleThermique.CalculePuissanceFiscale() + " " + Voiture.UNITE_PUISSANCE_FISCALE);
            Console.WriteLine("Prix carte grise : " + vielleThermique.CalculePrixCarteGrise() + " euros");
            Console.WriteLine("--------------------------");


            Voiture recenteThermique = new Voiture("DE-481-BE", "Kangoo", "Renault", Voiture.CAT_THERMIQUE, 2020, 96, 130);
            Console.WriteLine(recenteThermique);
            Console.WriteLine("Puissance fiscale : " + recenteThermique.CalculePuissanceFiscale() + " " + Voiture.UNITE_PUISSANCE_FISCALE);
            Console.WriteLine("Prix carte grise : " + recenteThermique.CalculePrixCarteGrise() + " euros");

            Console.WriteLine("--------------------------");

            Voiture electrique = new Voiture("QF-196-TU", "ZOE", "Renault", Voiture.CAT_ELECTRIQUE, 2021, 50);
            Console.WriteLine(electrique);
            Console.WriteLine("Puissance fiscale : " + electrique.CalculePuissanceFiscale() + " " + Voiture.UNITE_PUISSANCE_FISCALE);
            Console.WriteLine("Prix carte grise : " + electrique.CalculePrixCarteGrise() + " euros");


            Voiture[] lesVoitures = new Voiture[5];
            lesVoitures[0] = new Voiture("AZ-123-RT", "3008", "Peugeot", Voiture.CAT_THERMIQUE, 2010, 82, 135); ;
            lesVoitures[1] = new Voiture("DE-481-BE", "Kangoo", "Renault", Voiture.CAT_THERMIQUE, 2020, 96, 130);
            lesVoitures[2] = new Voiture("QF-196-TU", "ZOE", "Renault", Voiture.CAT_ELECTRIQUE, 2021, 50);
            lesVoitures[3] = new Voiture("AD-879-RT", "Coopers", "Mini", Voiture.CAT_THERMIQUE, 2022, 131, 134); ;
            lesVoitures[4] = new Voiture("SS-111-TE", "Model S", "Tesla", Voiture.CAT_ELECTRIQUE, 2020, 760);


            Console.WriteLine("----------------------------------------");
            Console.WriteLine("VOITURES ELECTRIQUES ");
            Console.WriteLine("----------------------------------------");
            Program.Affiche(lesVoitures, Voiture.CAT_ELECTRIQUE);

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("VOITURES THERMIQUES ");
            Console.WriteLine("----------------------------------------");
            Program.Affiche(lesVoitures, Voiture.CAT_THERMIQUE);


            double moyenne = Program.EmissionCO2Moyenne(lesVoitures);
            Console.WriteLine("Emission moyenne : " + moyenne);

        }

        private static double EmissionCO2Moyenne(Voiture[] lesVoitures)
        {
            double sum = 0;
            foreach(Voiture v in lesVoitures) { sum += v.EmissionCO2; };

            return sum / lesVoitures.Length;
        }

        private static void Affiche(Voiture[] lesVoitures, string categorie)
        {
            List<Voiture> voitureToPrint = GetVoitureByCategory(lesVoitures, categorie);

            voitureToPrint.ForEach(voiture =>
            {
                Console.WriteLine(voiture.ToString());
                Console.WriteLine("----------------------------------------");
            });

            Console.WriteLine($"{voitureToPrint.Count} véhicules trouvés");
            Console.WriteLine("----------------------------------------");
        }

        private static List<Voiture> GetVoitureByCategory(Voiture[] lesVoitures, string categorie)
        {
            List<Voiture> voitures = new List<Voiture>();

            foreach (Voiture voiture in lesVoitures)
            {
                if (voiture.Categorie.Equals(categorie)) voitures.Add(voiture);
            }

            return voitures;
        }
    }
}