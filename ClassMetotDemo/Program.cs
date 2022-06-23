using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.name = "meryem";
            customer1.surname = "hatay";
            customer1.job = "engineer";
            customer1.city = "hatay";
            customer1.salary = 4000;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.name = "elif";
            customer2.surname = "gider";
            customer2.city = "bursa";
            customer2.job = "software";
            customer2.salary = 10000;


            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.name = "sevde";
            customer3.surname = "gursular";
            customer3.city = "izmir";
            customer3.job = "software";
            customer3.salary = 10000;

            Customer[] customers = new Customer[] {customer1,customer2,customer3 };

            CustomerManager customerManager1 = new CustomerManager();
            customerManager1.delete(customer1);
            customerManager1.add(customer1);
            Console.WriteLine("-----------------------");
            CustomerManager customerManager2 = new CustomerManager();
            customerManager2.delete(customer2);
            customerManager2.add(customer2);
            Console.WriteLine("-----------------------");
            CustomerManager customerManager3 = new CustomerManager();
            customerManager3.delete(customer3);
            customerManager3.add(customer3);
            Console.WriteLine("-----------------------");

            customerManager3.list(customer3);
            customerManager2.list(customer2);
            customerManager1.list(customer1);



            Console.ReadLine();

        }


    }
}
