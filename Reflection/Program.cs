using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2, 3);
            //dortIslem.Topla2();
            //dortIslem.Topla(3,4); 

            //Console.WriteLine(dortIslem.Topla(3,4));
            //Console.WriteLine(dortIslem.Topla2());

            var type = typeof(DortIslem);
            //DortIslem dortIslem =  (DortIslem)Activator.CreateInstance(type,6,8);

            //Console.WriteLine(dortIslem.Topla(2,1));


         var instance = Activator.CreateInstance(type, 6, 8);

         Console.WriteLine(instance.GetType().GetMethod("Topla2").Invoke(instance, null));

            var metodlar = type.GetMethods();
            foreach (var info in metodlar)
            {
                Console.WriteLine("Metod adı : {0}",info.Name);
            }
         

            Console.ReadLine();
        }
       public  class DortIslem
        {
            private int _sayi1;
            private int _sayi2;
            public DortIslem(int sayi1,int sayi2)
            {
                _sayi1 = sayi1;
                _sayi2 = sayi2;

            }
            public DortIslem()
            {

            }
            public int Topla(int sayi1,int sayi2)
            {
                return sayi1 + sayi2;
            }
            public int Carp(int sayi1, int sayi2)
            {
                return sayi1 * sayi2;
            }
            public int Topla2()
            {
                return _sayi1 + _sayi2;
            }
            public int Carp2()
            {
                 
                return _sayi1 * _sayi2;
            }
        }

    }
}
