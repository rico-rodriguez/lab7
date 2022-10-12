using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public class DataInterop
    {
        public static void AddItem(List<IFloatable> ListOfBoats)
        {
            Console.WriteLine("Select a floatable object");
            Console.WriteLine("[0]: Carrier");
            Console.WriteLine("[1]: Sailboat");
            Console.WriteLine("[2]: Paddleboat");
            Console.WriteLine("[3]: Duck");
            Console.WriteLine("[4]: Trash");

            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "0":
                    Console.WriteLine("You Chose Carrier");
                    var myCarrier = new Carrier(true, false, 0);
                    ListOfBoats.Add(myCarrier);
                    break;
                case "1":
                    Console.WriteLine("You Chose Sail Boat");
                    var mySailboat = new Sailboat(true, false, 0);
                    ListOfBoats.Add(mySailboat);
                    break;
                case "2":
                    Console.WriteLine("You Chose Paddle Boat");
                    var myPaddleboat = new Paddleboat(true, false, 0);
                    ListOfBoats.Add(myPaddleboat);
                    break;
                case "3":
                    Console.WriteLine("You Chose Duck");
                    var myDuck = new Duck(0, false, "white");
                    ListOfBoats.Add(myDuck);
                    break;
                case "4":
                    Console.WriteLine("You Chose Trash");
                    var myTrash = new Trash(0, false, "black");
                    ListOfBoats.Add(myTrash);
                    break;

                default:
                    break;
            }


        }
        public static void UpdateItem(List<IFloatable> ListOfBoats)
        {
            int index = Menu.GetUserInputAsInt($"Provide an index number to update less than: [{ListOfBoats.Count()}]");

            var selected = ListOfBoats[index];

            if (selected is (Carrier))
            {
                var carrier = (Carrier)selected;
                carrier.ToString();
                carrier.UpdateMenu((Carrier)selected);
            }
            if (selected is (Paddleboat))
            {
                var paddleboat = (Paddleboat)selected;
                paddleboat.ToString();
                paddleboat.UpdateMenu((Paddleboat)selected);
            }
            if (selected is (Sailboat))
            {
                var sailboat = (Sailboat)selected;
                sailboat.ToString();
                sailboat.UpdateMenu((Sailboat)selected);
            }
            if (selected is (Trash))
            {
                var trash = (Trash)selected;
                trash.ToString();
                trash.UpdateMenu((Trash)selected);
            }
            if (selected is (Duck))
            {
                var duck = (Duck)selected;
                duck.ToString();
                duck.UpdateMenu((Duck)selected);
            }
        }
        public static void DeleteItem(List<IFloatable> ListOfBoats)
        {
            Console.WriteLine("Delete Item");

            //ListOfBoats.Remove();

        }
        public static void ListItems(List<IFloatable> ListOfBoats, string choice)
        {
            Console.WriteLine("");

            //ListOfBoats.Add();

        }
        //public struct MenuOptions
        //{
        //    public MenuOptions(string menuOption, );
        //}
    }
}
