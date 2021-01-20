using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetodDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Customer added: " + customer.Name + " " + customer.Surname);
            Console.ReadKey();
        }

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Customer deleted: " + customer.Name + " " + customer.Surname);
            Console.ReadKey();
        }
    }
}
