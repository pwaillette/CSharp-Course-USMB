using System.Runtime.CompilerServices;

namespace Exo4_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = GetBirthdayDate();

            Console.WriteLine(dateTime.ToLongDateString());
            Console.WriteLine("Date du jour : " + DateTime.Today);
            Console.WriteLine(dateTime.AddYears(20 - (dateTime.Year + 20 - 2000)));
        }

        static DateTime GetBirthdayDate()
        {
            Console.WriteLine("Entrez votre date de naissance sous le format dd/mm/aaaa");
            String date = Console.ReadLine();
            int year;
            int month;
            int day;
            bool yearB = int.TryParse(date.Substring(date.LastIndexOf("/") + 1), out year);
            bool monthB = int.TryParse(date.Substring(date.IndexOf("/") + 1, 2), out month);
            bool dayB = int.TryParse(date.Substring(0, 2), out day);

            return new DateTime(yearB ? year : 2000, monthB ? month : 01, dayB ? day : 01);
        }
    }
}