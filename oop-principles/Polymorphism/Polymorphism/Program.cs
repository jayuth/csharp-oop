using System;

namespace Polymorphism
{
    class Shape
    {
        protected int m_xpos;
        protected int m_ypos;

        public Shape()
        {
        }

        // condtructor to initialize fields
        public Shape(int x, int y)
        {
            m_xpos = x;
            m_ypos = y;
        }

        // the keyword virtual in the base class allows us to implement specific version of Draw in derived classes
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a SHAPE at {0},{1}", m_xpos, m_ypos);
        } 
    }

    class Square : Shape
    {
        public Square()
        {
        }

        public Square(int x, int y) : base(x, y)
        {
        }

        // override Draw method from base class
        /*
        public override void Draw()
        {
            Console.WriteLine("Drawing a SQUARE at {0},{1}", m_xpos, m_ypos);
        }
        */

        // if we did not override Draw() from base class, the Draw() in base class would be called
        public new void Draw()
        {
            Console.WriteLine("Drawing a SQUARE at {0},{1}", m_xpos, m_ypos);
        }
    }

    class Circle : Shape
    {
        public Circle()
        {
        }

        public Circle(int x, int y) : base(x, y)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a CIRCLE at {0},{1}", m_xpos, m_ypos);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Since Square and Circle are derived from shape, we can put them in array type Shape
            Shape[] shapes = new Shape[3];
            shapes[0] = new Shape(100, 100);
            shapes[1] = new Square(200, 200);
            shapes[2] = new Circle(300, 300);

            foreach (Shape shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}
