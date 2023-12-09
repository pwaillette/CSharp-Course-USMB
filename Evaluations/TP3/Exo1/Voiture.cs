using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exo1
{
    internal class Voiture
    {
        public const String CAT_THERMIQUE = "T";
        public const String CAT_ELECTRIQUE = "E";
        public const String UNITE_PUISSANCE = "KW";
        public const String UNITE_PUISSANCE_FISCALE = "CV";
        public const String UNITE_EMISSION_CO2 = "G/KM";
        public const double VALEUR_CV = 41;
        public const int ANNEE_NOUVEAU_CALCUL = 2019;

        private int dateHomologation;
        private string categorie;
        private string denomination;
        private double emissionCO2;
        private string numImmat;
        private string marque;
        private double puissance;

        public Voiture(string numImmat, string denomination, string marque, string categorie, int dateHomologation, double puissance, double emissionCO2)
        {
            Categorie = categorie;
            Denomination = denomination;
            EmissionCO2 = emissionCO2;
            NumImmat = numImmat;
            DateHomologation = dateHomologation;
            Marque = marque;
            Puissance = puissance;
        }

        public Voiture(string immatriculation, string denomination, string marque, string categorie, int anneeHomologation, double puissance)
        {

            if (!categorie.Equals(CAT_ELECTRIQUE)) throw new Exception("Signature pour voiture électrique appelée sans être une voiture électrique.");

            Categorie = categorie;
            Denomination = denomination;
            EmissionCO2 = 0;
            NumImmat = immatriculation;
            DateHomologation = anneeHomologation;
            Marque = marque;
            Puissance = puissance;
        }

        public string Categorie
        {
            get => categorie;
            set
            {
                if (!String.Equals(value, CAT_ELECTRIQUE) && !String.Equals(value, CAT_THERMIQUE)) throw new ArgumentException("Veuillez entrer une catégorie de véhicule valide (E/T)");
                categorie = value;
            }
        }
        public string Denomination
        {
            get => denomination;
            set
            {
                if (String.IsNullOrEmpty(value)) throw new ArgumentException("Veuillez entrer la dénomation de la voiture.");
                denomination = value;
            }
        }
        public double EmissionCO2
        {
            get => emissionCO2;
            set
            {
                emissionCO2 = value;
            }
        }
        public string NumImmat
        {
            get => numImmat; 
            set
            {
                Regex reg = new Regex("^[A-Z]{2}-[1-9]{3}-[A-Z]{2}$");
                if (!reg.IsMatch(value)) throw new ArgumentException("Veuillez entrer une plaque d'immatriculation valide.");
                numImmat = value;
            }
        }
        public int DateHomologation
        {
            get => dateHomologation; 
            set
            {
                DateTime date = DateTime.Today;
                // Date 
                if (DateTime.Compare(date, new DateTime(value, date.Month, date.Day, 0, 0, 0)) < 0) throw new ArgumentException("Veuillez entrer une date inférieure ou égale à aujourd'hui.");
                dateHomologation = value;
            }
        }
        public string Marque
        {
            get => marque; 
            set
            {
                if (String.IsNullOrEmpty(value)) throw new ArgumentException("Veuillez entrer la marque de la voiture.");
                marque = value;
            }
        }
        public double Puissance
        {
            get => puissance; 
            set
            {
                if (value < 0) throw new ArgumentException($"La puissance {nameof(value)} n'est pas valide.");
                puissance = value;
            }
        }

        public double CalculePuissanceFiscale()
        {
            if (Categorie.Equals(CAT_ELECTRIQUE)) return Math.Round((0.00018 * Math.Pow(Puissance, 2)) + (0.0387 * Puissance + 1.34));
            else if (DateHomologation < ANNEE_NOUVEAU_CALCUL) return Math.Round((EmissionCO2 / 45) + Math.Pow((Puissance / 40), 1.6));
            else return Math.Round(1.34 + (1.8 * Math.Pow((Puissance / 100), 2)) + (3.87 * (puissance / 100)));
        }

        public double CalculePrixCarteGrise()
        {
            return Math.Round(VALEUR_CV * CalculePuissanceFiscale());
        }

        public override bool Equals(object? obj)
        {
            return obj is Voiture voiture &&
                   dateHomologation == voiture.dateHomologation &&
                   categorie == voiture.categorie &&
                   denomination == voiture.denomination &&
                   emissionCO2 == voiture.emissionCO2 &&
                   numImmat == voiture.numImmat &&
                   marque == voiture.marque &&
                   puissance == voiture.puissance &&
                   Categorie == voiture.Categorie &&
                   Denomination == voiture.Denomination &&
                   EmissionCO2 == voiture.EmissionCO2 &&
                   NumImmat == voiture.NumImmat &&
                   DateHomologation == voiture.DateHomologation &&
                   Marque == voiture.Marque &&
                   Puissance == voiture.Puissance;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(dateHomologation);
            hash.Add(categorie);
            hash.Add(denomination);
            hash.Add(emissionCO2);
            hash.Add(numImmat);
            hash.Add(marque);
            hash.Add(puissance);
            hash.Add(Categorie);
            hash.Add(Denomination);
            hash.Add(EmissionCO2);
            hash.Add(NumImmat);
            hash.Add(DateHomologation);
            hash.Add(Marque);
            hash.Add(Puissance);
            return hash.ToHashCode();
        }

        public override string? ToString()
        {
            return $"Immatriculation : {NumImmat}\n" +
                   $"Denomination : {Denomination}\n" +
                   $"Marque : {Marque}\n" +
                   $"Année Homologation : {DateHomologation}\n" +
                   $"Puissance : {Puissance} {UNITE_PUISSANCE}\n" +
                   $"Emission CO2 : {EmissionCO2} {UNITE_EMISSION_CO2}";
        }

        public static bool operator ==(Voiture? left, Voiture? right)
        {
            return EqualityComparer<Voiture>.Default.Equals(left, right);
        }

        public static bool operator !=(Voiture? left, Voiture? right)
        {
            return !(left == right);
        }
    }
}
