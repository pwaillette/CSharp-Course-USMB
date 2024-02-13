using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo3_FormatJSON
{
    internal class Score : IComparable
    {
        private int nbPoints = 0;
        private string prenom = "";

        public Score(int nbPoints, string prenom)
        {
            this.NbPoints = nbPoints;
            this.Prenom = prenom;
        }

        public int NbPoints { get => nbPoints; set => nbPoints = value; }
        public string Prenom { get => prenom; set => prenom = value; }

        public override bool Equals(object? obj)
        {
            return obj is Score score &&
                   nbPoints == score.nbPoints &&
                   prenom == score.prenom &&
                   NbPoints == score.NbPoints &&
                   Prenom == score.Prenom;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(nbPoints, prenom, NbPoints, Prenom);
        }

        public override string ToString()
        {
            return this.Prenom + " : " + this.NbPoints + " points";
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Score))
                throw new ArgumentException("Le paramètre doit être un score !");
            return this.NbPoints.CompareTo(((Score)obj).NbPoints);
        }
    }
}
