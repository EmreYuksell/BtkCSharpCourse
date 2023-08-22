using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //CustomerManager customerManager = new CustomerManager();
            //customerManager.List();
            //Console.ReadLine();
            //Product product = new Product { Id=1, Name="Emre"};
            //Product product2 = new Product(2,"Computer");

            //EmployeManager employeManager = new EmployeManager(new DatabaseLogger());
          
            //employeManager.Add2();
            PersonManager personManager = new PersonManager("Product");
            personManager.Add();
            Teacher.Number = 10;
            Utilities.Validate();
            Manager.DoSomething();
            Manager manager = new Manager();
            manager.DoSomething2();
            Console.ReadLine();

        }
    

    }
    //class CustomerManager
    //{
    //    int _count = 15;
    //    public CustomerManager(int count)
    //    {
    //        _count = count;
    //    }
    //    public CustomerManager()
    //    {

    //    }
    //    public void List()
    //    {
    //        Console.WriteLine("Listed {0} items",_count);
    //    }
    //    public void Add()
    //    {
    //        Console.WriteLine("Added");
    //    }
    //}
    //class Product
    //{
    //    public Product()
    //    {

    //    }
    //    private int _id;
    //    private string _name;
    //    public Product(int id, string name)
    //    {
    //        _id = id;
    //        _name = name;
           
    //    }

    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
    //interface ILogger
    //{
    //    void Log();
    //}
    //class DatabaseLogger : ILogger
    //{
    //    public void Log()
    //    {
    //        Console.WriteLine("Logged to db");
    //    }

    //}

    //class FileLogger : ILogger
    //{
    //    public void Log()
    //    {
    //        Console.WriteLine("Logged to File");
    //    }
    //}
    //class EmployeManager
    //{
    //    private ILogger _logger;
    //    public EmployeManager(ILogger logger)
    //    {
    //        _logger = logger;
    //    }
        
    //    public void Add2()
    //    {
    //        _logger.Log();
    //        Console.WriteLine("Added!");
    //    }
    //}
    class BaseClass
    {
       private  string _entity;
        public BaseClass(string entity)
        {
            _entity= entity;
        }
        public void Message(string entity)
        {
            Console.WriteLine(" {0} message",_entity);
        }
    }

    class PersonManager:BaseClass
    {

        public PersonManager(string entity):base(entity)
        {

        }
        public void Add()
        {
            Console.WriteLine("Added to db");
            Message(String.Empty);
        }
    }
    static class Teacher
    {
        public static int Number { get; set; }

    }
    static class Utilities
    {
        public static void Validate()
        {
            Console.WriteLine("Validation is done");
        }
    }
    class Manager
    {
        public static void DoSomething()
        {
            Console.WriteLine("Done");
        }
        public void DoSomething2()
        {
            Console.WriteLine("Done 2");        }
    }
}

