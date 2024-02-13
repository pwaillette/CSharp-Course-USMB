namespace Exo4_CalculRemboursementSecu
{
    internal class Program
    {
        static readonly double tauxRemboursementSecu = 0.7;
        static readonly double tauxRemboursementMutuelle = 0.3;

        static void Main(string[] args)
        {
            double prixConsultation, prixRemboursementSecu, prixRemboursementMutuelle;

            Console.WriteLine("CALCUL DU REMBOURSEMENT DE LA SECU");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Prix de la consultation :");
            prixConsultation = double.Parse(Console.ReadLine());

            prixRemboursementSecu = prixConsultation * tauxRemboursementSecu;
            prixRemboursementMutuelle = prixConsultation * tauxRemboursementMutuelle;

            Console.WriteLine("Prix remboursé par la sécu : " + prixRemboursementSecu);
            Console.WriteLine("Prix remboursé par la mutuelle : " + prixRemboursementMutuelle);
        }
    }
}