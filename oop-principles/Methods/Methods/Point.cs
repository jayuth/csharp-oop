using System;
namespace Methods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public void Move(int x, int y) 
        {
            this.X = x;
            this.Y = y;
        }

        // pass a Point object
        public void Move(Point newLocation) 
        {
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");

            // reduce duplicate of field initialization
            Move(newLocation.X, newLocation.Y);

            /* use this object to change the values of our fields
            this.X = newLocation.X;
            this.Y = newLocation.Y;
            */           
        }
    }
}
