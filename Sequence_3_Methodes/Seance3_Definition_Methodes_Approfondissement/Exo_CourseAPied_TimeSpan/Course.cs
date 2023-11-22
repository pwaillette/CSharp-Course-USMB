using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_CourseAPied_TimeSpan
{
    internal class Course
    {
        public static double CalculeVitesse(double nbKm, int nbMinutes)
        {
            if (nbKm < 0)
            {
                throw new ArgumentException("Le nombre de kilomètres parcourus doit être supérieur à 0");
            }
            else if (nbMinutes < 0)
            {
                throw new ArgumentException("Le nombre de minutes du trajet doit être supérieur à 0");
            }

            double heure = nbMinutes / 60.0;

            return Math.Round(nbKm / heure, 1);
        }

        public static int ConvertitTempsEnMinutes(String temps)
        {
            int heures = int.Parse(temps.Split(':')[0]);
            int minutes = int.Parse(temps.Split(':')[1]);

            return (heures * 60) + minutes;
        }

        public static double NbKmPourAtteindreVitesse(int nbMin, double vitesse)
        {
            return Math.Round(vitesse * (nbMin / 60.0), 1);
        }

        public static double NbKmPourAtteindreVitesse(TimeSpan minutes, double vitesse)
        {
            int nbMin = (int)minutes.TotalMinutes;
            return Math.Round(vitesse * (nbMin / 60.0), 1);
        }

        public static int NbMinPourAtteindreVitesse(double nbKm, double vitesse)
        {
            return (int)Math.Round((nbKm / vitesse) * 60, 1);
        }

        public static string ConvertitMinutesEnTemps(int minutes)
        {
            int heure = minutes/ 60;
            int mins = minutes % 60;

            return heure.ToString("D2") + ":" + mins.ToString("D2");
        }
    }
}
