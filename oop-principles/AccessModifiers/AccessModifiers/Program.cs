using System;

namespace AccessModifiers
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Promote method is a public interface that users can interact with
        public void Promote()
        {
            var rating = CaluculateRating(excludeOrders: true);
            if (rating == 0)
            {
                Console.WriteLine("Promoted to Level 1");
            }
            else
            {
                Console.WriteLine("Promoted to Level 2");
            }
        }

        // implement detail method should be declared as private to avoid tight copling design
        // if this method is changed e.e. new business rules, then other classes that depend on this class will break
        private int CaluculateRating(bool excludeOrders)
        {
            return 0;
        }

        /*
        protected int CaluculateRating(bool excludeOrders)
        {
            return 0;
        }
         */
    }

    public class GoldCustomer : Customer
    {
        // example of a derived class accessing an implement detail method in its parent class. If logic of that method is changed, this class will break because of dependency
        /*
        public void OfferVoucher()
        {
            var rating = CaluculateRating(excludeOrders: true);
        }
        */
    }

    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
        }
    }
}
