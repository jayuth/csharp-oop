using System;
using System.Collections.Generic;

namespace ComprehensiveInterface
{
    class Program
    {
        private static List<IProductModel> AddSampleData()
        {
            List<IProductModel> output = new List<IProductModel>();

            // create each object for specific product
            output.Add(new PhysicalProductModel { Title = "BOSE nc 700" });
            output.Add(new PhysicalProductModel { Title = "Book A" });
            output.Add(new PhysicalProductModel { Title = "Book A" });

            // add digital product
            output.Add(new DigitalProductModel { Title = "Star Wars" });

            return output;
        }

        private static CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                FirstName = "Jay",
                LastName = "Uthairat",
                City = "Cincinnati",
                EmailAddress = "jay.uth@home.com",
                PhoneNumber = "123-555-0999"
            };
        }

        static void Main(string[] args)
        {
            // interface allows us to put more than one product type to the List
            List<IProductModel> cart = AddSampleData();
            // initialize customer object
            CustomerModel customer = GetCustomer();

            foreach (IProductModel prod in cart)
            {
                prod.ShipItem(customer);
            }

            Console.ReadLine();
        }
    }
}
