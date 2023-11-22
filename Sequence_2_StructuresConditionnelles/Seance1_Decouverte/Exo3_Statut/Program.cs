namespace Exo3_Statut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint age = GetAge();
            string statut = GetStatut(age);

            Console.WriteLine("Statut: " + statut);
        }

        static uint GetAge()
        {
            Console.WriteLine("Age ?");
            return uint.Parse(Console.ReadLine());
        }

        static string GetStatut(uint age)
        {
            return age switch
            {
                <= 9 => "Enfant",
                <= 13 => "Pré Adolescent",
                <= 17 => "Adolescent",
                > 17 => "Adulte"
            };
        }
    }
}