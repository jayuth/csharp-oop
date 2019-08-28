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
            output.Add(new PhysicalProductModel { Title = "Book B" });

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
            // we don't know what is in the cart but we all know that it will follow the contract defined in IProductModel
            List<IProductModel> cart = AddSampleData();
            // initialize customer object
            CustomerModel customer = GetCustomer();

            foreach (IProductModel prod in cart)
            {
                prod.ShipItem(customer);

                // if prod is also type IDigitalProductModel, do the following
                if (prod is IDigitalProductModel digital)
                {
                    // digital can also access Title property because it also implemented IProductModel
                    Console.WriteLine($"For the { digital.Title } you have { digital.TotalDownloadsLeft } downloads left.");
                }
            }

            Console.ReadLine();
        }
    }
}
