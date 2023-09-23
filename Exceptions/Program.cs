using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //ExceptionIntro();
            //TryCatch();
            //ActionDemo();


            
            
          //Console.WriteLine(Topla(2, 3));

            Func<int, int, int> add = Topla;
            Console.WriteLine(add(3,5));


            Func<int> getRandomNumber = delegate ()
            {
                Random random = new Random();
                return random.Next(1, 122);
            };
           
                Console.WriteLine(getRandomNumber());

            Func<int> getRandomNumber2 = () => new Random().Next(1, 100);
            Console.WriteLine(getRandomNumber2());
            Console.ReadLine();

        }

        static int Topla(int x, int y)
        {
            return x + y;
        }
        private static void TryCatch()
        {
            try
            {
                Find();
            }
            catch (Exception expection)
            {

                Console.WriteLine(expection.Message);
            }

          

        }
        private static void ActionDemo()
        {
            HandleException(() =>
            {

                Find();
            });
        }
        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private static void Find()
        {
            List<String> students = new List<string> { "Emre", "Engin", "Salih"};

           
            if (!students.Contains("Ahmet")){
                throw new RecordNotFoundException("Record Not Found");
}
            else
{
    Console.WriteLine("Record Found");
}

        }
        private static void ExceptionIntro()
        {
            try
            {
                string[] stundets = new string[3] { "Emre", "Engin", "Salih" };
                stundets[3] = "Ahmet";
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
        }
    }
}
