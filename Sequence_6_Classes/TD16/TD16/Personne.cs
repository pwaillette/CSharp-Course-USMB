using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD16
{
    public class Personne
    {
        public static readonly double POIDS_MAX = 1000;
        public static readonly string UNITE_MESURE_POIDS = "kg";
        public static readonly string UNITE_MESURE_TAILLE = "m";

        private String nom;

        private String prenom;
        
        private double poids;

        private double taille;

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
                this.prenom = value;
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
                this.prenom = value;
            }
        }
        public double Poids 
        {
            get
            {
                return this.poids;
            }
            set 
            { 
               
                this.poids = value;
            }
        }
        public double Taille 
        {
            get
            { 
                return this.taille;
            }

            set => taille = value; 
        }

    }
}
