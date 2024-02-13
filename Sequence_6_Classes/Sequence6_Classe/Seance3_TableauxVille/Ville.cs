using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seance3_TableauxVille
{
    internal class Ville
    {
        private string codePostal;
        private string nom;
        private int nbHabitants;
        private double superficie;
        private double densite;

        public string CodePostal
        {
            get { return codePostal; }
            set
            {
                codePostal = value;
            }
        }

        public string Nom
        {
            get { return nom; }
            set
            {
                nom = value;
            }
        }

        public int NbHabitants
        {
            get { return nbHabitants; }
            set
            {
                nbHabitants = value;
            }
        }

        public double Superficie
        {
            get { return superficie; }
            set
            {
                superficie = value;
            }
        }

        public double Densite
        {
            get { return densite; }
            set
            {
                densite = value;
            }
        }

        public const string UniteSuperficie = "km²";
        public const string UniteDensite = "hab/km²";

        public Ville(string codePostal, string nom, int nbHabitants, double superficie)
        {
            CodePostal = codePostal;
            Nom = nom;
            NbHabitants = nbHabitants;
            Superficie = superficie;
        }

        public override string ToString()
        {
            return $"Code Postal: {CodePostal}, Nom: {Nom}, Habitants: {NbHabitants}, Superficie: {Superficie} {UniteSuperficie}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Ville other = (Ville)obj;
            return Nom == other.Nom && CodePostal == other.CodePostal;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nom, CodePostal);
        }

        public static bool operator ==(Ville v1, Ville v2)
        {
            return v1.Equals(v2);
        }

        public static bool operator !=(Ville v1, Ville v2)
        {
            return !(v1 == v2);
        }

        public static bool operator >(Ville v1, Ville v2)
        {
            return v1.NbHabitants > v2.NbHabitants;
        }

        public static bool operator <(Ville v1, Ville v2)
        {
            return v1.NbHabitants < v2.NbHabitants;
        }

        public static bool operator >=(Ville v1, Ville v2)
        {
            return v1.NbHabitants >= v2.NbHabitants;
        }

        public static bool operator <=(Ville v1, Ville v2)
        {
            return v1.NbHabitants <= v2.NbHabitants;
        }

        public bool APlusDeSuperficie(Ville v)
        {
            return Superficie > v.Superficie;
        }

        public double CalculDensite()
        {
            return Math.Round(NbHabitants / Superficie, 1);
        }

        public bool EstPlusDense(Ville v)
        {
            return CalculDensite() > v.CalculDensite();
        }

        public bool EstPrefecture()
        {
            return CodePostal.EndsWith("000");
        }

        public bool EstDansLeMemeDepartement(Ville v)
        {
            return GetDepartement() == v.GetDepartement();
        }

        public int GetDepartement()
        {
            return int.Parse(CodePostal.Substring(0, 2));
        }

        public bool EstDansLeDepartement(int departement)
        {
            if (departement < 1 || departement > 95)
            {
                throw new ArgumentOutOfRangeException(nameof(departement), "Le département doit être compris entre 1 et 95.");
            }

            return GetDepartement() == departement;
        }

        public static Ville operator +(Ville v1, Ville v2)
        {
            return new Ville(v1.CodePostal, v1.Nom, v1.NbHabitants + v2.NbHabitants, v1.Superficie + v2.Superficie);
        }

        public string Categorie
        {
            get
            {
                if (NbHabitants >= 2_000 && NbHabitants <= 5_000)
                    return "bourg";
                else if (NbHabitants > 5_000 && NbHabitants <= 20_000)
                    return "petite ville";
                else if (NbHabitants > 20_000 && NbHabitants <= 50_000)
                    return "ville moyenne";
                else if (NbHabitants > 50_000 && NbHabitants <= 200_000)
                    return "grande ville";
                else
                    return "métropole";
            }
        }
    }
}
