using System;
namespace ComprehensiveInterface
{
    // an interface is a contract - all members are public, no implementation
    public interface IProductModel
    {
        string Title { get; set; }

        // property signature
        // get only = readonly - only return value, not set value
        bool HasOrderBeenCompleted { get; }

        // method signature
        void ShipItem(CustomerModel customer);
    }
}
