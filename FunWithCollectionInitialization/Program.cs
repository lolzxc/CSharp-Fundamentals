using System.Drawing;

namespace FunWithCollectionInitialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<Rectangle> myListOfRects = new List<Rectangle>
            {
                new Rectangle
                {
                    Height = 10, Width = 10,
                    Location = new Point { X = 10, Y = 10 } },
                new Rectangle
                {
                    Height = 15, Width = 15,
                    Location = new Point { X = 15, Y = 15 } }
            };
            foreach (var r in myListOfRects)
            {
                Console.WriteLine(r);
            }
        }
    }
}