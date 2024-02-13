using System.Xml;
using System.Xml.Serialization;

namespace Exo4_FormatXML
{
    internal class Program
    {
        private static List<Score> scores = new List<Score>();
        private static readonly String Path = @"Data\Scores.xml";

        static void Main(string[] args)
        {
            LoadFile();
            PrintScores();
            RegisterNewScores();
            WriteFile();
        }

        private static void WriteFile()
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Score>));
            try
            {
                StreamWriter writer = new StreamWriter(Path);
                xs.Serialize(writer, scores);
                writer.Close();
            }
            catch (Exception e) { Console.WriteLine(e); }
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

        private static void LoadFile()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Score>));
            StreamReader sr = new StreamReader(Path, System.Text.Encoding.UTF8);

            scores = (List<Score>)serializer.Deserialize(sr);
            sr.Close();
        }
    }
}