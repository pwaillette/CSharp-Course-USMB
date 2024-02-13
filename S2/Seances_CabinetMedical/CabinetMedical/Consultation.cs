using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetMedical
{
    public class Consultation
    {
        public const double AGE_MAX_TRES_JEUNE_ENFANT = 2;
        public const double AGE_MAX_JEUNE_ENFANT = 5;
        public const double SUPP_TRES_JEUNE_ENFANT = 5;
        public const double SUPP_JEUNE_ENFANT = 3;
        public const double SUPP_DIMANCHE = 20;
        public const double SUPP_DEPLACEMENT = 10;
        public const double TAUX_REMBOURSEMENT_DOC_TRAITANT = 0.7;
        public const double TAUX_REMBOURSEMENT_DOC_NON_TRAITANT = 0.3;
        public const string MONNAIE = "€";

        private bool aDomicile;
        private bool estDocteurtraitant;
        private Docteur unDocteur;
        private DateTime unJourUnHoraire;
        private Patient unPatient;

        public Consultation(bool aDomicile, bool estDocteurtraitant, DateTime unJourUnHoraire, Docteur unDocteur, Patient unPatient)
        {
            ADomicile = aDomicile;
            EstDocteurtraitant = estDocteurtraitant;
            UnJourUnHoraire = unJourUnHoraire;
            UnDocteur = unDocteur;
            UnPatient = unPatient;
        }

        public Consultation() { }

        public bool ADomicile { get => aDomicile; set => aDomicile = value; }
        public bool EstDocteurtraitant { get => estDocteurtraitant; set => estDocteurtraitant = value; }
        public DateTime UnJourUnHoraire { get => unJourUnHoraire; set => unJourUnHoraire = value; }
        public Docteur UnDocteur { get => unDocteur; set => unDocteur = value; }
        public Patient UnPatient { get => unPatient; set => unPatient = value; }

        public double CalculPrixConsultation()
        {
            double prixTotal = UnDocteur.DonneSonTarif();

            if (UnPatient.Age <= AGE_MAX_TRES_JEUNE_ENFANT)
            {
                prixTotal += SUPP_TRES_JEUNE_ENFANT;
            }
            else if (UnPatient.Age <= AGE_MAX_JEUNE_ENFANT)
            {
                prixTotal += SUPP_JEUNE_ENFANT;
            }

            if (UnJourUnHoraire.DayOfWeek == DayOfWeek.Sunday)
            {
                prixTotal += SUPP_DIMANCHE;
            }

            if (ADomicile)
            {
                prixTotal += SUPP_DEPLACEMENT;
            }

            return prixTotal;
        }

        public double CalculRemboursementSecu()
        {
            if (EstDocteurtraitant)
            {
                return Math.Round(CalculPrixConsultation() * TAUX_REMBOURSEMENT_DOC_TRAITANT, 2);
            }
            else
            {
                return Math.Round(CalculPrixConsultation() * TAUX_REMBOURSEMENT_DOC_NON_TRAITANT, 2);
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is Consultation consultation &&
                   ADomicile == consultation.ADomicile &&
                   EstDocteurtraitant == consultation.EstDocteurtraitant &&
                   UnJourUnHoraire == consultation.UnJourUnHoraire &&
                   EqualityComparer<Docteur>.Default.Equals(UnDocteur, consultation.UnDocteur) &&
                   EqualityComparer<Patient>.Default.Equals(UnPatient, consultation.UnPatient);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ADomicile, EstDocteurtraitant, UnJourUnHoraire, UnDocteur, UnPatient);
        }

        public override string ToString()
        {
            return $"Consultation le {UnJourUnHoraire.ToShortDateString()} à {UnJourUnHoraire.ToShortTimeString()} " +
                   $"avec le docteur {UnDocteur.UnNom}, " +
                   $"patient : {UnPatient.Nom} {UnPatient.Prenom}, " +
                   $"à domicile : {ADomicile}, docteur traitant : {EstDocteurtraitant}";
        }
    }
}
