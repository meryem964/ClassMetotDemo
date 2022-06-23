using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class CustomerManager
    {
        public void add(Customer customer)
        {
            Console.WriteLine(customer.name+" "+customer.surname+" added");
        }

        public void delete(Customer customer)
        {
            Console.WriteLine(customer.name+" "+customer.surname+" deleted");
        }

        public void list(Customer customer)
        {
            Console.WriteLine("customer Id:"+customer.Id);
            Console.WriteLine(customer.name+" " +customer.surname);
            Console.WriteLine(customer.city+" "+customer.job+" "+customer.salary);
            Console.WriteLine("                    ");
        }

    }
}
