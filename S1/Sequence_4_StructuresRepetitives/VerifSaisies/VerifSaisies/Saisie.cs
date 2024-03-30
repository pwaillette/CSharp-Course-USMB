using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerifSaisies
{
    internal class Saisie
    {
        public static int SaisieInt()
        {
            int res;
            bool reussi = int.TryParse(Console.ReadLine(), out res);
            while (!reussi)
            {
                Console.WriteLine("Erreur de saisie. Il faut un entier : ");
                reussi = int.TryParse(Console.ReadLine(), out res);
            }
            return res;
        }
    }
}
