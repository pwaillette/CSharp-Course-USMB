using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie1_GestionStocks
{
    internal class Dimension
    {
        private double hauteur;
        private double largeur;
        private double profondeur;
        public const string UNITE_MESURE = "cm";
        public const string UNITE_VOLUME = "m3";

        public Dimension(double hauteur, double largeur, double profondeur)
        {
            Hauteur = hauteur;
            Largeur = largeur;
            Profondeur = profondeur;
        }

        public Dimension() { }

        public double Volume()
        {
            return Hauteur * Largeur * Profondeur;
        }

        public override string ToString()
        {
            return $"{Hauteur}x{Largeur}x{Profondeur}{UNITE_MESURE}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Dimension dimension &&
                   Hauteur == dimension.Hauteur &&
                   Largeur == dimension.Largeur &&
                   Profondeur == dimension.Profondeur;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hauteur, Largeur, Profondeur);
        }

        public double Hauteur { get => hauteur; set => hauteur = value; }
        public double Largeur { get => largeur; set => largeur = value; }
        public double Profondeur { get => profondeur; set => profondeur = value; }
    }
}
