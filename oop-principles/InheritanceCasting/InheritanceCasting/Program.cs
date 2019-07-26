using System;
using System.IO;

namespace InheritanceCasting
{
    class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Draw()
        {
        }
    }

    class Text : Shape
    {
        public int FontSize { get; set; }
        public int FontName { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // downcasting
            //Shape shape = new Text();

            Text text = new Text();
            // upcasting - convert a derived class to a base class
            // both shape and text objects are now point to the same memory
            Shape shape = text;

            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width);
        }
    }
}
