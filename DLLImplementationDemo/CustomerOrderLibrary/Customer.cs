using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerOrderLibrary
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public String CustomerName { get; set; }

        public void GetCustomerInfo()
        {
            Console.WriteLine("enter customerid and customername");
            CustomerId = Convert.ToInt32(Console.ReadLine());
            CustomerName = Console.ReadLine();

        }
        public void DisplayCustomerInfo()
        {
            Console.WriteLine($"CustomerID ={CustomerId}");
            Console.WriteLine($"Customername={CustomerName}");
        }
    }
}
