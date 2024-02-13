using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Enseignant
{
    internal class Enseignant
    {
        public static double VAL_INDICE = 4.85;
        public const int NB_ANNEE_EVOLUTION_INDICE = 2;
        public const int PAS_INDICE = 10;
        public const String CATEGORIE_CERTIFIEE = "CERTIFIE";
        public const String CATEGORIE_AGREGEE = "AGREGE";
        public const int INDICE_CATEGORIE_CERTIFIEE = 440;
        public const int INDICE_CATEGORIE_AGREGEE = 450;

        private int anciennete;
        private string categorie;
        private string nom;
        private string numen;
        private string prenom;
        private double taux;

        public Enseignant(string numen, string nom, string prenom, string categorie, int anciennete, double taux)
        {
            this.anciennete = anciennete;
            this.categorie = categorie;
            this.Prenom = prenom;
            this.Taux = taux;
            this.Nom = nom;
            this.Numen = numen;
        }

        /*public Enseignant(string numen, string nom, string prenom, string categorie, int anciennete)
        {
            this.anciennete = anciennete;
            this.nom = nom;
            this.numen = numen;
            this.prenom = prenom;
        }*/

        public int Anciennete
        {
            get
            {
                return this.anciennete;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Anciennete doit être > 0");
                this.anciennete = value;
            }
        }

        public string Categorie
        {
            get
            {
                return this.categorie;
            }
            set
            {
                if (value != CATEGORIE_CERTIFIEE && value != CATEGORIE_AGREGEE)
                { throw new ArgumentException("Le grade doit être renseigné"); }
                this.categorie = value;
            }
        }

        public string Nom
        {
            get
            {
                return this.nom;
            }
            set
            {
                if (String.IsNullOrEmpty(value))
                { throw new ArgumentException("Le nom doit être renseigné"); }
                string i = value.Substring(0, 1);
                if (i != i.ToUpper())
                { throw new ArgumentException("Le nom doit être renseigné"); }
                this.nom = value;
            }
        }

        public string Numen
        {
            get
            {
                return this.numen;
            }
            set
            {
                int i = value.Length;
                if (i != 13)
                { throw new ArgumentOutOfRangeException("Numen doit être composé de 13 chiffres"); }         
                //string c = value.Substring(0, 2);
                //string a = value.Substring(2);
                // string cc = value.Substring(3, 7);
                //string aa = value.Substring(9, 3);
                Regex formatNumen = new Regex("^[0-9]{2}[A-Z]{1}[0-9]{7}[A-Z]{3}$");
                if (!formatNumen.IsMatch(value))
                {
                    { throw new ArgumentOutOfRangeException("Numen doit doit avoir le format  CCACCCCCCCAAA "); }
                }
                this.numen = value;
            }
        }

        public string Prenom
        {
            get
            {
                return this.prenom;
            }

            set
            {
                if (String.IsNullOrEmpty(value))
                { throw new ArgumentException("Le prenom doit être renseigné"); }
                string i = value.Substring(0, 1);
                if (i != i.ToUpper())
                { throw new ArgumentException("Le prenom doit être renseigné"); }
                this.prenom = value;
            }
        }

        public double Taux
        {
            get
            {
                return this.taux;
            }
            set
            {
                if (value != 0 && value != 1)
                { throw new ArgumentException("Le taux doit être compris entre 0 et 1"); }
                this.taux = value;
            }
        }

        public override bool Equals(object? obj)
        {
            return obj is Enseignant enseigant &&
                   this.numen == enseigant.numen;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.numen);
        }

        public override string? ToString()
        {
            return "Numen : " + this.numen + "\nNom : " + this.nom + "\nPrenom : " + this.prenom + "\nCategorie : " + this.categorie + "\nAncienneté : " + this.anciennete + "\nTaux : " + this.taux;
        }

        public static int CalculeIndice(int anciennete, string categorie)
        {
            //NB_ANNEE_EVOLUTION_INDICE
            int j = 0;
            if (j <= anciennete && anciennete >= NB_ANNEE_EVOLUTION_INDICE)
                j = j + NB_ANNEE_EVOLUTION_INDICE;
              
            int indice = 0;
            if (categorie == CATEGORIE_CERTIFIEE)
            {
                indice = INDICE_CATEGORIE_CERTIFIEE + j * PAS_INDICE;
            }
            if (categorie == CATEGORIE_AGREGEE)
            {
                indice = INDICE_CATEGORIE_AGREGEE + j * PAS_INDICE; 
            }
            return indice;
        }

        public static double CalculeSalaire (string categorie)
        {
            double ctgr = 0;

            if (categorie == CATEGORIE_CERTIFIEE)
            {
                ctgr = VAL_INDICE * INDICE_CATEGORIE_CERTIFIEE;
            }
            if (categorie == CATEGORIE_AGREGEE)
            {
                ctgr = VAL_INDICE * INDICE_CATEGORIE_AGREGEE;
            }
            return Math.Round(ctgr, 2);
           
        }

       
    }

}
