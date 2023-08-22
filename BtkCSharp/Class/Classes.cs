using BtkCSharp.Class;

internal class Program
{
    public static void Main(string[] args)
    {

        {
            CustomerManager customerManager = new CustomerManager();

            customerManager.Add();
            customerManager.Update();
            

            Customer customer = new Customer 
            { 
            Id = 1,City = "Istanbul" , FirstName="Emre",LastName="Yuksel"
            
            };

            Console.WriteLine(customer.FirstName);
            Console.ReadLine();
        }
    }
}
    
