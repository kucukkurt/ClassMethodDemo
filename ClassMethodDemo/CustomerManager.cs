using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    public class CustomerManager
    {
        List<Customer> customers = new List<Customer>();
        public void Add(Customer customer)
        {
            
            customers.Add(customer);
            Console.WriteLine("Customer Added!" + customer.customerName);
        }

        public void Delete(Customer customer)
        {
            customers.Remove(customer);
            Console.WriteLine("Customer Deleted!" + customer.customerName);
        }

        public void GetAllCustomer()
        {
            List<Customer> _customers = customers;
            Console.WriteLine("All customer were listed to below");

                foreach (var name in _customers)
                {
                    
                    Console.WriteLine("All customer :" + name.customerName);
                }
            

        }
    }
}
