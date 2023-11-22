using System.Net.Mail;

namespace Exo3_Mail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String address = GetMailAddress();
            int addressLength = address.Length;
            int arobasePosition = address.IndexOf("@");
            String extension = address.Substring(address.LastIndexOf(".") + 1);
            String domain = address.Substring(address.IndexOf("@") + 1, (address.LastIndexOf(".") - 1) - address.IndexOf("@"));

            Console.WriteLine("Longueur de l'adresse : " + addressLength + "\nPosition du @ : " + arobasePosition + "\nDomain: " + domain + "\nExtension : " + extension);
        }

        static string GetMailAddress()
        {
            Console.WriteLine("Veuillez entrer une adresse e-mail valide :");
            string emailaddress = Console.ReadLine();
            return emailaddress;
        }
    }
}