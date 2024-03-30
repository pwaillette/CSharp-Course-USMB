namespace Exo3_ConversionCelciusFarenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celcius, farenheit; // Déclaration des variables
            Console.WriteLine("Celcius ?");
            celcius = double.Parse(Console.ReadLine()); // Récupération des Celcius

            farenheit = (1.8 * celcius) + 32; // Calcul de la valeur en fahrenheit

            Console.WriteLine(celcius + " degrés Celcius <=> " + farenheit + " degrés Fahrenheit"); // Affichage des résultats
        }
    }
}