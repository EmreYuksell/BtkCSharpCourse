﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result =  utilities.BuildList<string>("Ankara","İzmir","Adana");

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
            List<Customer> result2 = utilities.BuildList<Customer>(new Customer { FirstName = "Emre" }, (new Customer { FirstName = "Engin" });<
            foreach (var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }
            Console.ReadLine();
        }
        class Utilities
        {   
              public List<T>BuildList<T>(params T[] items)
            {
                return new List<T>(items);
            }  
        }

        class Customer
        {
            public string FirstName { get; set; }

        }
        

        class Product
        {

        }

        
        interface IProductDal : IRepository<Product>
        {

        }
        interface IProduct
        {

        }
        interface ICustomerDal:IRepository<Customer> 
        {

        }
        interface IRepository<T> where T:class, new()
        {
            List<T> GetAll();
            T Get(int id);
            void Add(T entity);

            void Delete(T entity);
            void Update(T entity);
        }
        class ProductDal : IProductDal
        {
            public void Add(Product entity)
            {
                throw new NotImplementedException();
            }

            public void Delete(Product entity)
            {
                throw new NotImplementedException();
            }

            public Product Get(int id)
            {
                throw new NotImplementedException();
            }

            public List<Product> GetAll()
            {
                throw new NotImplementedException();
            }

            public void Update(Product entity)
            {
                throw new NotImplementedException();
            }
        }
        class CustomerDal : ICustomerDal
        {
            public void Add(Customer entity)
            {
                throw new NotImplementedException();
            }

            public void Delete(Customer entity)
            {
                throw new NotImplementedException();
            }

            public Customer Get(int id)
            {
                throw new NotImplementedException();
            }

            public List<Customer> GetAll()
            {
                throw new NotImplementedException();
            }

            public void Update(Customer entity)
            {
                throw new NotImplementedException();
            }
        }
    }
}
