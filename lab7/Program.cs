using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace lab7
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IFloatable> ListOfBoats = new List<IFloatable>();

            var choice = Menu.GetUserInputAsString();

            DataInterop.AddItem(ListOfBoats);

            DataInterop.UpdateItem(ListOfBoats);

            //foreach (var item in ListOfBoats)
            //{
            //    Console.WriteLine(item);
            //}

            //AddItem(ListOfBoats);
            //var paddleboat = new Paddleboat(true, false, 20);
            //var duck = new Duck(156, false, "red");
            //var carrier = new Carrier(false, true, 50);

            //Console.WriteLine(paddleboat.ToString());
            //Console.WriteLine(carrier.ToString());
        }


    }
}