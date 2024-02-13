namespace Exo1_Salut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String nom;
            String prenom;

            Console.WriteLine("Nom:");
            nom = Console.ReadLine();

            Console.WriteLine("Prénom:");
            prenom = Console.ReadLine();

            Console.WriteLine("-------------");
            Console.WriteLine("Salut " + prenom + " " + nom + "!");
        }
    }
}