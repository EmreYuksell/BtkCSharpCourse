using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList();
            //List();
            

            Dictionary<string, string> dictioanry = new Dictionary<string, string>();
            dictioanry.Add("Table","tablo");
            dictioanry.Add("Computer", "Bilgisayar");
            Console.WriteLine(dictioanry["Table"]);

            foreach (var item in dictioanry)
            {
                Console.WriteLine(item.Value);
            }
            Console.WriteLine(dictioanry.ContainsKey("glass"));
            Console.ReadLine();

        }


        private static void ArrayList()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Karabük");

            foreach (var city in cities)
            {
                Console.WriteLine(city);

            }
            
        }



        class Customer
        {
            public int Id { get; set; }
            public string FirstName { get; set; }

        }
        
        private static void List()
        {
            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("AAA");

            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }
            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer {Id= 1,FirstName="Emre" });
            //customers.Add(new Customer { Id = 2, FirstName = "Yüksel" });

            List<Customer> customers = new List<Customer>
            {
           new Customer { Id = 1, FirstName = "Emre" },//Farklı yazım
           new Customer { Id = 2, FirstName = "Yüksel" }
            };


            var customer2 = new Customer
            {
                Id = 3,
                FirstName = "Serkan"
            };

            customers.Add(customer2);
            customers.AddRange(new Customer[2]
            {
            new Customer{Id=4,FirstName="Sinemizu"},
            new Customer{Id=5,FirstName="Emre"}
            });



            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName, customer.Id);
                Console.WriteLine(customer.Id);
            }
            var count = customers.Count;
            Console.WriteLine("Count: {0}", count);
        }

    }
    //11

}
