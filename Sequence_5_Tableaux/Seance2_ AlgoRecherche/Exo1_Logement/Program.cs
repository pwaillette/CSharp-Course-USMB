namespace Exo1_Logement
{
    internal class Program
    {
        public static readonly double[] TARIFS = new double[] { 500,
650, 800, 1100 };

        static void Main(string[] args)
        {
            int piece = int.Parse(VerifSaisies.Saisie.SaisieStringParmis("Nombre de pièces ?", new string[]{"1", "2", "3", "4"}));
            double loyer = GetLoyerByPieceNumber(piece);

            Console.WriteLine("Loyer Mensuel : " + loyer + " euros");
        }

        public static double GetLoyerByPieceNumber(int pieceNumber)
        {
            return TARIFS[pieceNumber - 1];
        }
    }
}