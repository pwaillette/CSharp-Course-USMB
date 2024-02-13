using System.Text.Json;
using static System.Formats.Asn1.AsnWriter;

namespace Exo3_FormatJSON
{
    internal class Program
    {
        private static List<Score> scores = new List<Score>();
        private static readonly String Path = @"Data\Scores.json";

        static void Main(string[] args)
        {
            LoadFile();
            PrintScores();
            RegisterNewScores();
            WriteFile();
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
                scores.Add(newScore);
                PrintScores();
            }
        }

        private static void PrintScores()
        {
            scores.Sort();
            scores.Reverse();
            Console.WriteLine("--------------------------------------------------------");

            foreach (var score in scores)
            {
                Console.WriteLine(score);
            }

            Console.WriteLine("--------------------------------------------------------");
        }

        public static void WriteFile()
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            var jsonString = JsonSerializer.Serialize(scores, options);
            File.WriteAllText(Path, jsonString);
        }

        public static void LoadFile()
        {
            string content = File.ReadAllText(Path);
            scores = JsonSerializer.Deserialize<List<Score>>(content);
        }
    }
}