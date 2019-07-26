using System;

namespace Fields
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order()); // Add an Order object to a list
            customer.Orders.Add(new Order());

            customer.Promote(); // calling this method modifies the value in the List so we should change Order to read-only variable

            Console.WriteLine(customer.Orders.Count);

        }
    }
}
