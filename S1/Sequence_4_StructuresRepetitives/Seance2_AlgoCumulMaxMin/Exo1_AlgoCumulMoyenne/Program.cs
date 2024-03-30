namespace Exo1_AlgoCumulMoyenne
{
    internal class Program
    {
        const string QUIT = "Q";
        const int MIN_NOTE = 0;
        const int MAX_NOTE = 20;

        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("      SAISIE");
            Console.WriteLine("--------------------------------------");

            int i = 0;
            double sum = 0;
            int maxNote = 0;
            int minNote = 20;
            int nbNoteSous10 = 0;
            int nbNoteSupEg10 = 0;

            while (true)
            {
                Console.WriteLine("Note " + (i + 1) + " ? (Q pour quitter)");
                string input = Console.ReadLine();

                if (input == QUIT) break;

                int inp = int.Parse(input);

                if (inp < MIN_NOTE || inp > MAX_NOTE) {
                    Console.WriteLine("Note doit être comprise entre 0 et 20");
                    break;
                }

                i++;
                sum += inp;

                if (inp >= maxNote)
                {
                    maxNote = inp;
                } 
                
                if (inp <= minNote)
                {
                    minNote = inp;
                }

                if (inp < 10) nbNoteSous10++;
                else nbNoteSupEg10++;
            }

            double moy = Math.Round(sum/i, 2);

            Console.WriteLine("--------------------------------------");
            Console.WriteLine("      STATISTIQUES");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Nb note : " + i);
            Console.WriteLine("Note max : " + maxNote);
            Console.WriteLine("Note min : " + minNote);
            Console.WriteLine("Nb note >= 10 : " + nbNoteSupEg10);
            Console.WriteLine("Nb note < 10 : " + nbNoteSous10);
            Console.WriteLine("Moyenne : " + moy);
        }
    }
}