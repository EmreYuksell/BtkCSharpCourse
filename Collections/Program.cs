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

            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Karabük");

            foreach (var city in cities )
            {
                Console.WriteLine(city);

            }
            Console.ReadLine();
        }
    }
}
