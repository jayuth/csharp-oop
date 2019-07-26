using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {

            // not use constructor to initialize fields
            /*
            var customer1 = new Customer(1, "Jay");
            customer1.Id = 111;
            customer1.Name = "John";
            */          

            // use constructor to initialize fields
            var customer = new Customer(1, "Jay");
            Console.WriteLine(customer.Name);
            Console.WriteLine(customer.Id);

            var order = new Order();
            // customer.Order = new List<Order>(); // should not initialize Order list in the Main function 
            customer.Orders.Add(order);

        }
    }
}
