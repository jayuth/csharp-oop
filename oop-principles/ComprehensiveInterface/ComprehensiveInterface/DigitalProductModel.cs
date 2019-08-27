using System;
namespace ComprehensiveInterface
{
    public class DigitalProductModel : IProductModel
    {
        public string Title { get; set; }

        public bool HasOrderBeenCompleted { get; private set; }

        // add new property specially for this class
        public int TotalDownloadsLeft { get; private set; } = 5;

        public void ShipItem(CustomerModel customer)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating emailing { Title } to { customer.EmailAddress }");
                TotalDownloadsLeft -= 1;
                if (TotalDownloadsLeft < 1)
                {
                    HasOrderBeenCompleted = true;
                    TotalDownloadsLeft = 0;
                }
            }
        }
    }
}
