using ClassMethodDemo;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer1 = new Customer
            {
                customerId = 1,
                customerName = "Erhan",
                customerSurName = "küçükkurt",
                IdentityNo = 1234567890
            };

            Customer customer2 = new Customer
            {
                customerId = 2,
                customerName = "Beyza",
                customerSurName = "Küçükkurt",
                IdentityNo = 1122334455
            };


            Customer customer3 = new Customer
            {
                customerId = 3,
                customerName = "Turan",
                customerSurName = "Akyıldız",
                IdentityNo = 1111111111
            };
            

            CustomerManager customerManager = new CustomerManager();


            customerManager.Add(customer1);

            customerManager.Add(customer2);

            customerManager.Add(customer3);

            Console.WriteLine("********************");


            customerManager.Delete(customer2);

            Console.WriteLine("********************");

            customerManager.GetAllCustomer();
        }
    }
}
