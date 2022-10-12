using System.Xml.Linq;

namespace lab7
{
    public class Boat : IFloatable
    {
        //properties
        public bool IsDocked { get; set; }
        public bool IsEmbarked { get; set; }
        public int Capacity { get; set; }
        public Boat (bool isDocked, bool isEmbarked, int capacity)
        {
            this.IsDocked = isDocked;
            this.IsEmbarked = isEmbarked;
            this.Capacity = capacity;
        }
        //methods
        public string FloatCapacity(int capacity)
        {
            return $"We can fit {capacity} people";
        }
        public string Embarked()
        {
            IsEmbarked = true;
            IsDocked = false;
            return "Embarked!";
        }
        public string Docked()
        {
            IsEmbarked = false;
            IsDocked = true;
            return "Docked!";
        }

        public override string ToString()
        {
            return $"Your Boat has these properties: Docked: {IsDocked} | Embarked: {IsEmbarked} | Capacity: {Capacity}";
        }
        public void UpdateMenu(Boat selected)
        {
            Console.WriteLine("Which would you like to do?");
            Console.WriteLine("[0]: Dock the boat");
            Console.WriteLine("[1]: Set sail!");

            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "0":
                    Console.WriteLine("Pulling into port!");
                    selected.IsDocked = true;
                    selected.IsEmbarked = false;
                    break;
                case "1":
                    Console.WriteLine("Setting sail!");
                    selected.IsDocked = false;
                    selected.IsEmbarked = true;
                    break;
                default:
                    break;
            }
        }

        public string Floating()
        {
            return "Floating";
        }

        public string Seats(int seats)
        {
            return $"There are {seats} seats.";
        }

        public string Color(string color)
        {
            return $"This color is {color}";
        }
    }
}
