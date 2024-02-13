namespace Exo2_FormatCSV
{
    internal class Program
    {
        private static List<Score> Scores = new List<Score>();
        private static readonly String Path = @"Data\Scores.csv";

        static void Main(String[] args)
        {
            LoadFile();
            PrintScores();
            RegisterNewScores();
            WriteFile();
        }

        private static void WriteFile()
        {
            try
            {
                StreamWriter writer = new StreamWriter(Path);
                foreach (Score s in Scores)
                {
                    writer.WriteLine(s.NbPoints + ";" + s.Prenom);
                }
                writer.Close();
            }
            catch (Exception e) { Console.WriteLine("Problème avec le fichier \n" + e); }
        }

        private static void RegisterNewScores()
        {
            while (true)
            {
                Console.WriteLine("Entrez un nouveau score ? ou S pour stopper");
                String? input = Console.ReadLine();

                if (String.IsNullOrEmpty(input)) continue;
                else if (input.Equals("S")) break;

                int score = int.Parse(input);

                Console.WriteLine("Entrez le prénom du joueur ?");
                String? name = Console.ReadLine();

                if (String.IsNullOrEmpty(name)) continue;
                Score newScore = new Score(score, name);
                Scores.Add(newScore);
                PrintScores();
            }
        }

        private static void PrintScores()
        {
            Scores.Sort();
            Scores.Reverse();
            Console.WriteLine("--------------------------------------------------------");

            foreach (var score in Scores)
            {
                Console.WriteLine(score);
            }

            Console.WriteLine("--------------------------------------------------------");
        }

        private static void LoadFile() {
            try
            {
                StreamReader reader = new StreamReader(Path, System.Text.Encoding.UTF8);

                while (!reader.EndOfStream)
                {
                    String? joueur = reader.ReadLine();
                    if (String.IsNullOrEmpty(joueur)) continue;

                    String[] infos = joueur.Split(";");
                    Score score = new Score(int.Parse(infos[0]), infos[1]);
                    Scores.Add(score);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Problème avec le fichier \n" + e);
                Environment.Exit(2);
            }
        }
    }
}