using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie1_GestionStocks
{
    internal class Stock
    {
        private int laQuantite;
        private Meuble leMeuble;

        public Stock(int laQuantite, Meuble leMeuble)
        {
            LaQuantite = laQuantite;
            LeMeuble = leMeuble;
        }

        public Stock() { }

        public Stock(int laQuantite, double largeur, double hauteur, double profondeur, string reference, double prix)
        {
            LeMeuble = new Meuble(largeur, hauteur, profondeur, reference, prix);
            LaQuantite = laQuantite;
        }

        public int LaQuantite { get => laQuantite; set => laQuantite = value; }
        public Meuble LeMeuble { get => leMeuble; set => leMeuble = value; }

        public string CalculeMontant()
        {
            return (LaQuantite * LeMeuble.LePrix) + Meuble.MONNAIE;
        }

        public string  CalculeVolume()
        {
            return ((LaQuantite * LeMeuble.LaDimension.Volume())/1000000) + Dimension.UNITE_VOLUME;
        }

        public void AjouteStock(int nb)
        {
            LaQuantite += nb;
        }

        public bool RetireStock(int nb)
        {
            if (LaQuantite - nb < 0) return false;
            LaQuantite -= nb;
            return true;
        }

        public override bool Equals(object? obj)
        {
            return obj is Stock stock &&
                   LaQuantite == stock.LaQuantite &&
                   EqualityComparer<Meuble>.Default.Equals(LeMeuble, stock.LeMeuble);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(LaQuantite, LeMeuble);
        }

        public string FormatPrix()
        {
            return $"{LeMeuble.LaReference.ToUpper()}  {LaQuantite} X {LeMeuble.FormatPrix()} = {this.CalculeMontant()}";
        }

        public string FormatVolume()
        {
            return $"{LeMeuble.LaReference.ToUpper()}  {LaQuantite} X {LeMeuble.FormatVolume()} = {this.CalculeVolume()}";
        }

        public override string ToString()
        {
            return $"Reference: {LeMeuble.LaReference}\nPrix: {LeMeuble.FormatPrix()}\nDimension: {LeMeuble.LaDimension}\nQuantite: {LaQuantite}";
        }
    }
}
