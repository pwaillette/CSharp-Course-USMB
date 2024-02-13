namespace Exo1_FormatTxt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String pathData = @"data\joueurs.txt";

            List<String> lesJoueurs = new List<String>();

            try
            {
                StreamReader reader = new StreamReader(pathData, System.Text.Encoding.UTF8);

                while (!reader.EndOfStream)
                {
                    String? unJoueur = reader.ReadLine();
                    if (String.IsNullOrEmpty(unJoueur)) continue;
                    lesJoueurs.Add(unJoueur);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Problème avec le fichier \n" + e);
                Environment.Exit(2);
            }

            foreach (String joueur in lesJoueurs)
            {
                Console.WriteLine(joueur);
            }

            while (true)
            {
                Console.WriteLine("Nouveau Prénom ? Tappez s pour stopper");
                String? s = Console.ReadLine();
                if (String.IsNullOrEmpty(s)) continue;
                if (s == "s") break;
                if (lesJoueurs.Contains(s))
                {
                    Console.WriteLine("Prénom déjà existant !");
                    continue;
                } else lesJoueurs.Add(s);
            }

            lesJoueurs.Sort();

            try
            {
                StreamWriter writer = new StreamWriter(pathData);
                foreach(String j in lesJoueurs)
                {
                    Console.WriteLine(j);
                    writer.WriteLine(j);
                }
                writer.Close();
            } catch (Exception e) { Console.WriteLine("Problème avec le fichier \n" + e); }
        }
    }
}