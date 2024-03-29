﻿namespace Enseignant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Enseignant e = new Enseignant("23E2345567AZT", "Rappe", "Marc", "AGREDE", 3, 1) ;
            e.Numen = "23E2345567AZT";
            e.Nom = "Rappe";
            e.Prenom = "Marc";
            e.Categorie = "AGREGE";
            e.Anciennete = 3;
            e.Taux = 1;

            int indice = Enseignant.CalculeIndice(e.Anciennete, e.Categorie);
            double salaire = Enseignant.CalculeSalaire(e.Categorie);

            Console.WriteLine(e);
            Console.WriteLine("\nIndice : " + indice);
            Console.WriteLine("Salaire : " + salaire + "euros");
        }
        /*private static void Test()
        {
            
            Enseignant eTempsPleinAgregeSansAnciennete = new Enseignant("23E2345567AZT", "Rappe", "Marc", Enseignant.CATEGORIE_AGREGEE, 1);

            eTempsPleinAgregeSansAnciennete.Numen = "23E2345567AZT";
            eTempsPleinAgregeSansAnciennete.Nom = "Rappe";
            eTempsPleinAgregeSansAnciennete.Prenom = "Marc";
            eTempsPleinAgregeSansAnciennete.Categorie = "AGREGE";
            eTempsPleinAgregeSansAnciennete.Anciennete = 1;
            eTempsPleinAgregeSansAnciennete.Taux = 1;

            Console.WriteLine(eTempsPleinAgregeSansAnciennete);
            Console.WriteLine("Indice : " + eTempsPleinAgregeSansAnciennete.CalculeIndice());
            Console.WriteLine("Salaire : " + eTempsPleinAgregeSansAnciennete.CalculeSalaire(eTempsPleinAgregeSansAnciennete.Categorie) + " euros");
            Console.WriteLine("------------------------------------------------");
            Enseignant eTempsPartielAgregeSansAnciennete = new Enseignant("45E2345567ERT", "Baud", "Lilia", Enseignant.CATEGORIE_AGREGEE, 1, 0.8);
            Console.WriteLine(eTempsPartielAgregeSansAnciennete);
            Console.WriteLine("Indice : " + eTempsPartielAgregeSansAncien - nete.CalculeIndice());
            Console.WriteLine("Salaire : " + eTempsPartielAgregeSansAncien - nete.CalculeSalaire() + " euros");
            Console.WriteLine("------------------------------------------------");
            Enseignant eTempsPleinAgregeAvec2Ans = new Enseignant("35E2345567EET", "Simon", "Franck",
            Enseignant.CATEGORIE_AGREGEE, 3);
            Console.WriteLine(eTempsPleinAgregeAvec2Ans);
            Console.WriteLine("Indice : " + eTempsPleinAgregeAvec2Ans.CalculeIndice());
            Console.WriteLine("Salaire : " + eTempsPleinAgregeAvec2Ans.CalculeSalaire() + " euros");
            Console.WriteLine("------------------------------------------------");
            Enseignant eTempsPleinCertifieSansAnciennete = new Enseignant("11E2345567ABC", "Fillipe", "Léa",
            Enseignant.CATEGORIE_CERTIFIEE, 1);
            Console.WriteLine(eTempsPleinCertifieSansAnciennete);
            Console.WriteLine("Indice : " + eTempsPleinCertifieSansAncien - nete.CalculeIndice());
            Console.WriteLine("Salaire : " + eTempsPleinCertifieSansAncien - nete.CalculeSalaire() + " euros");
            Console.WriteLine("------------------------------------------------");
            Enseignant eTempsPartielCertifieSansAnciennete = new Enseignant("12E2345567DCE", "Foix", "Juline",
            Enseignant.CATEGORIE_CERTIFIEE, 1, 0.8);
            Console.WriteLine(eTempsPartielCertifieSansAnciennete);
            Console.WriteLine("Indice : " + eTempsPartielCertifieSansAncien - nete.CalculeIndice());
            Console.WriteLine("Salaire : " + eTempsPartielCertifieSansAncien - nete.CalculeSalaire() + " euros");
            Console.WriteLine("------------------------------------------------");
            Enseignant eTempsPleinCertifieAvec2Ans = new Enseignant("35E2345567EET", "Ra-mones", "Rico",
            Enseignant.CATEGORIE_CERTIFIEE, 3);
            Console.WriteLine(eTempsPleinCertifieAvec2Ans);
            Console.WriteLine("Indice : " + eTempsPleinCertifieAvec2Ans.CalculeIndice());
            Console.WriteLine("Salaire : " + eTempsPleinCertifieAvec2Ans.CalculeSalaire() + " euros");
        }*/

    }
}