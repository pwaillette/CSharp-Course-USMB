namespace Exo1_RepeterBonjour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*while (true)
            { Console.WriteLine("Hello !\n"); }*/

            bool encore = true;
            while (encore)
            {
                Console.WriteLine("Hello World!");
                Console.WriteLine("Encore ?");
                encore = (Console.ReadLine() == "O") ? true : false;
            }

            Console.WriteLine("Bye World!");
        }
    }
}