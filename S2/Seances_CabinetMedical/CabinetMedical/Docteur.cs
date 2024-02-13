using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CabinetMedical
{
    public enum CategorieDocteur
    {
        Generaliste = 0, Specialiste = 1,
        Specialiste_Complexe = 2, Specialiste_Tres_Complexe = 3
    };

    public class Docteur
    {
        public static readonly double[] TARIFS_CATEGORIES_DOCTEUR = new double[] { 25,
30, 46, 60 };
        private CategorieDocteur uneCategorie;
        private string unNom;

        public Docteur(CategorieDocteur uneCategorie, string unNom)
        {
            UneCategorie = uneCategorie;
            UnNom = unNom;
        }

        public Docteur() { }

        public CategorieDocteur UneCategorie { get => uneCategorie; set => uneCategorie = value; }
        public string UnNom { get => unNom; set => unNom = value; }

        public double DonneSonTarif()
        {
            return TARIFS_CATEGORIES_DOCTEUR[(int)UneCategorie];
        }

        public override bool Equals(object? obj)
        {
            return obj is Docteur docteur &&
                   UneCategorie == docteur.UneCategorie &&
                   UnNom == docteur.UnNom;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(UneCategorie, UnNom);
        }
    }
}
