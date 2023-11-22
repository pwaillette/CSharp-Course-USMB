using System.Drawing;

namespace Exo1_Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle1 = new Rectangle(20, 20, 100, 40);
            Rectangle rectangle2 = new Rectangle(new Point(110, 50), new Size(80, 20));

            Console.WriteLine(rectangle1);
            Console.WriteLine(rectangle2);

            bool intersection = rectangle1.IntersectsWith(rectangle2);
            Console.WriteLine("Intersection: " + intersection);

            rectangle1.Intersect(rectangle2);
            Console.WriteLine(rectangle1);

            bool isContained = rectangle1.Contains(rectangle2);
            Console.WriteLine(isContained);

            Point mixedPoint = new Point(111, 51);
            bool isPointContained = rectangle1.Contains(mixedPoint);
            Console.WriteLine(isPointContained);
        }
    }
}