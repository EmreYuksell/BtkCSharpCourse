using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Worker(),
                new Manager(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
        
            }
            IEat[] eats = new IEat[2]
        {
            new Worker(),
            new Manager()
        };

            foreach (var eat in eats)
            {
                eat.Eat();
            };
            ISalary[] salaries = new ISalary[2]
            {
                new Worker(),
                new Manager()
            };
            foreach(var salary in salaries)
            {
                salary.GetSalary();
            }
            Console.ReadLine();
         }


        interface IWorker
        {
            void Work();
                
        }

        interface IEat
        {
            void Eat();
        }

        interface ISalary
        {
            void GetSalary();
        }
        class Manager : IWorker, ISalary, IEat
        {
            public void Eat()
            {
                Console.WriteLine("Manager Eat");
            }

            public void GetSalary()
            {
                Console.WriteLine("Manager Salary");
            }

            public void Work()
            {
                Console.WriteLine("Manager Work");
            }
        }
        class Worker : IWorker, IEat, ISalary
        {
            public void Eat()
            {
                Console.WriteLine("Worker Eat");
            }

            public void GetSalary()
            {
                Console.WriteLine("Worker Salary");

            }
            
           public void Work()
            {
                Console.WriteLine("Worker work");
            }
        }
        class Robot : IWorker
        {
            public void Work()
            {
                Console.WriteLine("Robot work");
            }
        }
    }
}
