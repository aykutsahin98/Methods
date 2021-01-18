using System;
using System.Collections.Generic;
using System.Text;

namespace MethodsDemo
{
    class CustomerManager
    {
        public void Add (Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi " + customer.Name + " " + customer.LastName);
        }
        public void Remove(Customer customer)
        {
            Console.WriteLine("Müşteri Silindi " + customer.Name + " " + customer.LastName);
        }
        public void List(Customer [] customers)
        {
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Id + " " + customer.Name + " " + customer.LastName + " ");
            }
        }
    }
}
