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

            try
            {
                Find();
            }
            catch (Exception expection)
            {

               Console.WriteLine(expection.Message);
            }

            HandleException(() =>
            {

                Find();
            });

            Console.ReadLine();


            

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
