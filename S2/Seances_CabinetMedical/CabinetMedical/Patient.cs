using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetMedical
{
    public class Patient
    {
        private int age;
        private DateTime dateNaissance;
        private string nom;
        private string prenom;

        public Patient(string nom, string prenom, DateTime dateNaissance)
        {
            DateNaissance = dateNaissance;
            Nom = nom;
            Prenom = prenom;
        }

        public Patient(string nom, string prenom, string dateNaissance)
        {
            Nom = nom;
            Prenom = prenom;

            try
            {
                DateNaissance = DateTime.Parse(dateNaissance);
            } 
            catch( Exception ex)
            {
                Console.WriteLine("Erreur de chargement de la date de naissance: Veuillez vérifier votre entrée.");
            }
        }

        public Patient() { }

        public int Age { 
            get {
                DateTime aujourdHui = DateTime.Today;
                int age = aujourdHui.Year - DateNaissance.Year;

                if (DateNaissance.Date > aujourdHui.AddYears(-age))
                {
                    age--;
                }

                return age;
            }
        }
        public DateTime DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }

        public override bool Equals(object? obj)
        {
            return obj is Patient patient &&
                   Age == patient.Age &&
                   DateNaissance == patient.DateNaissance &&
                   Nom == patient.Nom &&
                   Prenom == patient.Prenom;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Age, DateNaissance, Nom, Prenom);
        }

        public override string ToString()
        {
            return $"Age: {Age}\nNom: {Nom}\nPrénom: {Prenom}";
        }
    }
}
