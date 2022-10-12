using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    public class Trash : IFloatable
    {
        //properties
        public int Capacity { get; set; }
        public bool Floats { get; set; }
        public string ColorOfObject { get; set; }
        public Trash(int capacity, bool floats, string color)
        {
            this.Capacity = capacity;
            this.Floats = floats;
            this.ColorOfObject = color;
        }
        public string FloatCapacity(int capacity)
        {
            return "No capacity available";
        }

        public string Floating()
        {
            throw new NotImplementedException();
        }
        public string Color(string color)
        {
            return $"This color is {color}";
        }
        public override string ToString()
        {
            return base.ToString() + " " + Capacity + " " + Floats + " " + ColorOfObject;
        }

        public void UpdateMenu(Trash selected)
        {
            Console.WriteLine("Which would you like to do?");
            Console.WriteLine("[0]: Change the color");

            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "0":
                    Console.WriteLine("Input a new color");
                    var userColor = Console.ReadLine();
                    selected.ColorOfObject = userColor;
                    Console.WriteLine($"The Color of the trash is now set to {selected.ColorOfObject}");
                    break;
                default:
                    break;
            }
        }

    }
}
