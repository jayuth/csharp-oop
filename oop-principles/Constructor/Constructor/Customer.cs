using System;
using System.Collections.Generic;

namespace Constructor
{
    public class Customer
    {
        // fields 
        public int Id;
        public string Name;
        public List<Order> Orders; // list of Order objects. Always initialize List of objects to empty list to prevent NULL object

        // parameterless constructor = default constructor
        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id)
            : this()
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
     
        {
            this.Name = name;
        }

    }
}


