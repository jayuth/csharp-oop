using System;
using System.Collections.Generic;

namespace Fields
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>(); 
        // we could initialize this field using a constructor 
        //but since this List is independent (the value of it not depend on the external), we can initialize it here.
        // Also, this way, the List will be initialized without atatching it to other methods

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name; 
        }

        public void Promote()
        {
            //Orders = new List<Order>();
        }
    }
}
