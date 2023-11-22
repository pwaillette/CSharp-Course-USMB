namespace Exo2_NumeroSecu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string secuNumber = GetSecuNumber();
            string year = secuNumber.Substring(1, 2);
            string month = secuNumber.Substring(3, 2);
            string departement = secuNumber.Substring(5, 2);
            string genre = (secuNumber.Substring(0, 1).Equals("2")) ? "née" : "né";

            Console.WriteLine("Vous êtes " + genre + " en " + month + "/" + year + " dans le département " + departement);
        }

        static string GetSecuNumber()
        {
            Console.WriteLine("Num secu (7 premiers chiffres ?");
            return String.IsNullOrEmpty(Console.ReadLine()) ? GetSecuNumber() : Console.ReadLine();
        }
    }
}