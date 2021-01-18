using System;

namespace MethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer person = new Customer();
            person.Id = 1;
            person.Name = "Aykut";
            person.LastName = "Şahin";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(person);

            Customer[] customers = new Customer[] { person };
            customerManager.List(customers);
        }
    }
}
