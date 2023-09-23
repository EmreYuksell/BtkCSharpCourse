using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class Program
    {
        public delegate void MyDelegate();
        public delegate void MyDelegate2(string text);
        public delegate int MyDelegate3(int number1,int number2);
        static void Main(string[] args)
        
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();

            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate();
            myDelegate+= customerManager.ShowAlert;
            myDelegate();

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;    
            myDelegate2 += customerManager.ShowAlert2;

            myDelegate2("Helloa");
            Mat mat = new Mat();
            MyDelegate3 myDelegate3 = mat.Topla;
           var sonuc = myDelegate3(2, 3);
            Console.WriteLine(sonuc);
            Console.ReadLine();
        }

    }

   public  class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("hello"); 

        }
        public void ShowAlert()
        {
            Console.WriteLine("Alert");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);

        }
        public void ShowAlert2(string alert)
        {
            Console.WriteLine(alert);
        }
       
        
    }
    public class Mat
    {

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
    }
}
