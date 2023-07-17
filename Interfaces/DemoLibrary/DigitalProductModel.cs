using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    internal class DigitalProductModel
    {
        public string Title { get; set; }
        public bool HasOrderBeenCompleted { get; private set; }
        public void ShipItem(CustomerModel customer)
        {
            if (HasOrderBeenCompleted == false)
            {
                Console.WriteLine($"Simulating shipping {Title} to {customer.EmailAddress}");
                HasOrderBeenCompleted = true;
            }
        }
    }
}
