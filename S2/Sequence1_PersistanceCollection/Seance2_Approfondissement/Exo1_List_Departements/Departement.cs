using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo1_List_Departements
{
    internal class Departement
    {
        private string chefLieu ;
        private string nom ;
        private string numero ;
        private double population ;
        private string region ;
        private double superficie ;

        public Departement() { }

        public Departement(string chefLieu, string nom, string numero, double population, string region, double superficie)
        {
            ChefLieu = chefLieu;
            Nom = nom;
            Numero = numero;
            Population = population;
            Region = region;
            Superficie = superficie;
        }

        public string ChefLieu { get => chefLieu; set => chefLieu = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Numero { get => numero; set => numero = value; }
        public double Population { get => population; set => population = value; }
        public string Region { get => region; set => region = value; }
        public double Superficie { get => superficie; set => superficie = value; }

        public override bool Equals(object? obj)
        {
            return obj is Departement departement &&
                   ChefLieu == departement.ChefLieu &&
                   Nom == departement.Nom &&
                   Numero == departement.Numero &&
                   Population == departement.Population &&
                   Region == departement.Region &&
                   Superficie == departement.Superficie;
        }

        public override int GetHashCode()
        {
            HashCode hash = new HashCode();
            hash.Add(ChefLieu);
            hash.Add(Nom);
            hash.Add(Numero);
            hash.Add(Population);
            hash.Add(Region);
            hash.Add(Superficie);
            return hash.ToHashCode();
        }

        public override string ToString()
        {
            return $"Chef-Lieu: {this.ChefLieu}\nNom: {this.Nom}\nNuméro: {this.Numero}\nPopulation: {this.Population:0} habitants\nRegion: {this.Region}\nSuperficie: {this.Superficie:0}";
        }
    }
}
