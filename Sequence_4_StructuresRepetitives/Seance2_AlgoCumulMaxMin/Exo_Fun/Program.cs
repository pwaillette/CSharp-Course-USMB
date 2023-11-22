namespace Exo_Fun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int screenNum = GetScreen();

            switch(screenNum)
            {
                case 1: ScreenOne(); break;
                case 2: ScreenTwo(); break;
                case 3: ScreenThree(); break;
                case 4: ScreenFour(); break;
                default: Console.WriteLine("Erreur : Numéro d'affichage entré invalide"); break;
            }
        }

        public static void ScreenTwo()
        {
            int stars = GetNumberOfStars();

            for (int i = 0; i <= stars; i++)
            {
                Console.WriteLine(new String('*', i));
            }
        }

        public static void ScreenThree()
        {
            int stars = GetNumberOfStars();

            for (int i = stars; i > 0; i--)
            {
                Console.WriteLine(new String('*', i));
            }
        }

        public static void ScreenFour()
        {
            int stars = GetNumberOfStars();

            for (int i = stars; i > 0; i--)
            {
                int scape = stars - i;
                Console.WriteLine(new String(' ', scape) + new String('*', i));
            }
        }

        public static void ScreenOne()
        {
            int starPerLines = GetStarPerLines();
            int stars = GetNumberOfStars();
            int leftStarsToCreate = stars;
            string str = "";

            for (int i = 0; i < stars; i++)
            {
                string strBuilder = "";
                int j = 0;
                while (j < starPerLines && leftStarsToCreate > 0)
                {
                    strBuilder += "*";
                    j++;
                    leftStarsToCreate--;
                }
                str += strBuilder + "\n";
            }

            Console.WriteLine(str);
        }

        public static int GetStarPerLines()
        {
            Console.WriteLine("Nombre d'étoile par ligne ?");
            return int.Parse(Console.ReadLine());
        }

        public static int GetNumberOfStars()
        {
            Console.WriteLine("Nombre d'étoiles ?");
            return int.Parse(Console.ReadLine());
        }

        public static int GetScreen()
        {
            Console.WriteLine("Numéro d'affichage ?");
            return int.Parse(Console.ReadLine());
        }
    }
}