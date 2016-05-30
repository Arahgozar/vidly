using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        private List<Customer> customers;
        public int CustomeId { get; set; }
        public string Name { get; set; }
        public List<Customer> GetCustomers ()
        {
            Customer customer = new Customer();
            customer.CustomeId = 1;
            customer.Name = "Arash Rahgozar";
            customers.Add(customer);
            customer = new Customer();
            customer.CustomeId = 2;
            customer.Name = "John Smith";
            customers.Add(customer);


            return customers;
        
        }
    }
}