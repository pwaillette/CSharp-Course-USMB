using System.Text.RegularExpressions;

namespace Enseignant
{
    internal class Enseignant
    {
        private const double VAL_INDICE = 4.85;
        private const int NB_ANNEE_EVOLUTION_INDICE = 2;
        public const String CATEGORIE_CERTIFIEE = "CERTIFIE";
        public const String CATEGORIE_AGREGEE = "AGREGE";
        private const int INDICE_CATEGORIE_CERTIFIEE = 440;
        private const int INDICE_CATEGORIE_AGREGEE = 450;

        private int anciennete;
        private string categorie;
        private string nom;
        private string numen;
        private string prenom;
        private double taux;

        public Enseignant(string numen, string nom, string prenom, string categorie, int anciennete, double taux)
        {
            Anciennete = anciennete;
            Categorie = categorie;
            Prenom = prenom;
            Taux = taux;
            Nom = nom;
            Numen = numen;
        }

        public Enseignant(string numen, string nom, string prenom, string categorie, int anciennete)
        {
            Anciennete = anciennete;
            Categorie = categorie;
            Prenom = prenom;
            Taux = 1;
            Nom = nom;
            Numen = numen;
        }        

        public int Anciennete
        {
            get => anciennete;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Anciennete doit être >= 0");
                anciennete = value;
            }
        }

        public string Categorie
        {
            get => categorie;
            set
            {
                if (value != CATEGORIE_CERTIFIEE && value != CATEGORIE_AGREGEE)
                {
                    throw new ArgumentException("Le grade doit être renseigné");
                }

                categorie = value;
            }
        }

        public string Nom
        {
            get => nom;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Le nom doit être renseigné");
                }

                string i = value.Substring(0, 1);
                if (i != i.ToUpper())
                {
                    throw new ArgumentException("Le nom doit être renseigné");
                }

                nom = value;
            }
        }

        public string Numen
        {
            get => numen;
            set
            {
                Regex formatNumen = new Regex("^[0-9]{2}[A-Z]{1}[0-9]{7}[A-Z]{3}$");
                if (!formatNumen.IsMatch(value)) throw new ArgumentOutOfRangeException("Numen doit doit avoir le format  CCACCCCCCCAAA.");
                numen = value;
            }
        }

        public string Prenom
        {
            get => prenom;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Le prenom doit être renseigné");
                }

                string i = value.Substring(0, 1);
                if (i != i.ToUpper())
                {
                    throw new ArgumentException("Le prenom doit être renseigné");
                }

                prenom = value;
            }
        }

        public double Taux
        {
            get => taux;
            set
            {
                if (value < 0 || value > 1) throw new ArgumentException("Le taux doit être compris entre 0 et 1");

                taux = value;
            }
        }
        
        public int CalculeIndice()
        {

            int i = Categorie == CATEGORIE_CERTIFIEE ? INDICE_CATEGORIE_CERTIFIEE : INDICE_CATEGORIE_AGREGEE;
            int bonus = (anciennete / NB_ANNEE_EVOLUTION_INDICE) * 10;

            return i + bonus;
        }

        public double CalculeSalaire()
        {
            int indice = (int)(CalculeIndice() * VAL_INDICE);

            return Math.Round(indice * Taux, 3);
        }

        public override bool Equals(object? obj)
        {
            return Numen.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return "Numen : " + numen + "\nNom : " + nom + "\nPrenom : " + prenom + "\nCategorie : " +
                   categorie + "\nAncienneté : " + anciennete + "\nTaux : " + taux;
        }
    }
}
