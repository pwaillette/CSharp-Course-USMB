using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo2_MesMaths
{
    internal class MesMaths
    {
        public static double Moyenne(double nb1, double nb2)
        {
            double res = Math.Round((nb1 + nb2) / 2, 1);
            return res;
        }

        public static double Moyenne(double nb1, double nb2, double nb3)
        {
            double res = Math.Round((nb1 + nb2 + nb3) / 3, 1);
            return res;
        }

        public static double Ecart(double nb1, double nb2)
        {
            return Math.Abs(nb1 - nb2);
        }

        public static double CalculPerimetreCercle(int rayon)
        {
            if (rayon < 0)
            {
                throw new ArgumentException("Le rayon ne peut pas être nul !");
            }

            return Math.Round(2 * Math.PI * rayon, 1);
        }

        public static double ConvertDegreeToRadiant(double degree)
        {
            double radian = Math.Round(degree * Math.PI / 180, 2);
            return radian;
        }

        public static int TireAuSort(int min, int max)
        {
            return new Random().Next(min, max + 1);
        }
    }
}
