namespace TD16
{
    class Program
    {
        static void Main(string[] args)
        {
            Personne p = new Personne();
            p.Prenom = "Tetyana";

            Personne n = new Personne();
            p.Nom = "Tarakanuha";

            Personne t = new Personne();
            p.Taille = 36;

            Personne pd = new Personne();
            p.Poids = 67;

            Console.WriteLine(p.Nom);
            Console.WriteLine(p.Prenom + p.Nom);
            Console.WriteLine(p.ToString());
        }   
    }

}