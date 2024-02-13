namespace Exo_Loto
{
    internal class Program
    {

        public static readonly int[] USER_NUMBERS = new int[5];
        public static readonly int[] WIN_NUMBERS = new int[5];
        public static readonly int CHANCE_NUMBER = new Random().Next(1, 10);
        public static readonly int GAIN_SANS_NUMERO_CHANCE = 0;
        public static readonly int GAIN_AVEC_NUMERO_CHANCE = 0;
        
        static void Main(string[] args)
        {
            GenerateWinNumbers();
            GetUserNumbers();
        }

        public static void GenerateWinNumbers()
        {
            for (int i = 0; i< WIN_NUMBERS.Length; i++)
            {
                int num = new Random().Next(1, 50);

                while (Contains(WIN_NUMBERS, num)) num = new Random().Next(1, 50);
                WIN_NUMBERS[i] = num;
            }
        }

        public static void GetUserNumbers()
        {
            for (int i = 0; i < USER_NUMBERS.Length; i++)
            {
                int num = 0;
                do
                {
                    num = VerifSaisies.Saisie.SaisieInt();
                    while (Contains(USER_NUMBERS, num)) num = VerifSaisies.Saisie.SaisieInt();
                } while (num < 1 || num > 50);

                USER_NUMBERS[i] = num;
            }
        }

        public static bool Contains(int[] arr, int val)
        {
            for (int i = 0; i< arr.Length; i++)
            {
                if (arr[i] == val) return true;
            }

            return false;
        }
    }
}