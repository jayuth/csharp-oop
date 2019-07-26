using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //var number = int.Parse("abc");

            int number;
            var result = int.TryParse("abc", out number);

            if (result)
                Console.WriteLine(number);
            else
                Console.WriteLine("Conversion failed.");
        }

        static void UseParams() 
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2, 3, 4)); // here we don't have to initialize an array because of the params keyword
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 5));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null); // we use the keyword "new" because we want to pass a Point object and to do that we need to initialize it first. Otherwise, object will be set to "NULL"
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured.");

            }
        }
    }
}
