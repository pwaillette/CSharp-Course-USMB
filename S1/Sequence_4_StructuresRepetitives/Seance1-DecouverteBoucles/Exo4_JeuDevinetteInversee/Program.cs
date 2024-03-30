namespace Exo4_JeuDevinetteInversee
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choisissez le début de l'intervalle : ");
            int debutIntervalle = int.Parse(Console.ReadLine());

            Console.Write("Choisissez la fin de l'intervalle : ");
            int finIntervalle = int.Parse(Console.ReadLine());
                
            if (finIntervalle <= debutIntervalle)
            {
                Console.WriteLine("L'intervalle n'est pas valide.");
                return;
            }

            Console.Write($"Choisissez un nombre entre {debutIntervalle} et {finIntervalle} : ");
            int nombreSecret = int.Parse(Console.ReadLine());

            int min = debutIntervalle;
            int max = finIntervalle;
            int tryNum;
            int nombreDeTentatives = 0;

            while (true)
            {
                tryNum = (min + max) / 2;
                nombreDeTentatives++;

                Console.WriteLine($"Proposition : {tryNum}");
                Console.Write("Est-ce le bon nombre ? (Oui/Plus grand/Plus petit) : ");
                string reponse = Console.ReadLine().ToLower();

                if (reponse == "oui")
                {
                    Console.WriteLine($"J'ai deviné le nombre {nombreSecret} en {nombreDeTentatives} tentatives!");
                    break;
                }
                else if (reponse == "plus grand")
                {
                    min = tryNum + 1;
                }
                else if (reponse == "plus petit")
                {
                    max = tryNum - 1;
                }
                else
                {
                    Console.WriteLine("Réponse non valide. Veuillez répondre par 'Oui', 'Plus grand' ou 'Plus petit'.");
                }
            }
        }
    }
}
