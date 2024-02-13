using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie1_GestionStocks
{
    internal class Meuble
    {
        private Dimension laDimension;
        private string laReference;
        private double lePrix;
        public const string MONNAIE = "euro(s)";

        public Meuble(Dimension laDimension, string laReference, double lePrix)
        {
            LaDimension = laDimension;
            LaReference = laReference;
            LePrix = lePrix;
        }

        public Meuble() { }

        public Meuble(double largeur, double hauteur, double profondeur, string laReference, double lePrix)
        {
            LaDimension = new Dimension(hauteur, largeur, profondeur);
            LaReference = laReference;
            LePrix = lePrix;
        }

        public Dimension LaDimension { get => laDimension; set => laDimension = value; }
        public string LaReference { get => laReference; set => laReference = value; }
        public double LePrix { get => lePrix; set => lePrix = value; }

        public override bool Equals(object? obj)
        {
            return obj is Meuble meuble &&
                   EqualityComparer<Dimension>.Default.Equals(LaDimension, meuble.LaDimension) &&
                   LaReference == meuble.LaReference &&
                   LePrix == meuble.LePrix;
        }

        public string FormatPrix()
        {
            return $"{lePrix} {MONNAIE}";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(LaDimension, LaReference, LePrix);
        }

        internal object FormatVolume()
        {
            return LaDimension.Volume();
        }
    }
}
