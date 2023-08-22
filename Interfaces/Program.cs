using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  InterfacesIntro();
            //  Demo();
            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                  new SqlServerCustomerDal(),
                  new OraceleCustomerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
             Console.ReadLine(); 
        }
        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }
        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Emre",
                LastName = "Yuksel",
                Adress = "Karabük"
            };

            Student student = new Student
            {
                Id = 1,
                FirstName = "Mert",
                LastName = "Ari",
                Department = "Computer Sciences"
            };
            manager.Add(customer);
            manager.Add(student);
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Adress { get; set; }

    }


    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
            
            
        }
    }
}