namespace Exo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // x,y : noms pas explicites car ce code n'a pas de sens 
            // si ce n'est de tester votre logique d'exécution 
            int x = 10, y = 1, res = 0;
            if (x < 5)
            {
                if (y > 3)
                    res = 1;
                if (x - y > 0)
                    res = 0;
                res++;
            }
            else if (x < 10)
            {
                res = x + 2;
                if (y >= 2)
                    res++;
                else
                    res--;
            }
            else
                res = 12;
            Console.WriteLine("res : " + res);
        }
    }
}