using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlserver = new SqlServer();
            sqlserver.Add();
            MySql mysql = new MySql();
            mysql.Add();
            Console.ReadLine();
        }
    }

    class Databes
    {
        public virtual void Add()
        {
            Console.WriteLine("Add by Default");
        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by Default");
        }

    }

    class SqlServer : Databes
    {

    }
    class MySql : Databes
    {

    }
}
