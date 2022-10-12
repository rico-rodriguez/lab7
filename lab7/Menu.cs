namespace lab7
{
    public class Menu
    {
        public void MenuChoice()
        {
            GetUserInputAsString();
        }
        public static void PrintMenu()
        {
            Console.WriteLine(new string('*', 80));

            Console.WriteLine("Please make your selection:");
            Console.WriteLine("[0]: Add an item");
            Console.WriteLine("[1]: Update an item");
            Console.WriteLine("[2]: Delete an item");
            Console.WriteLine("[3]: List a(n) item(s)");


            Console.WriteLine(new string('*', 80));

        }
        public static string GetUserInputAsString()
        {
            string input;
            bool stopLoop = false;
            do
            {
                PrintMenu();
                Console.WriteLine();
                input = Console.ReadLine();
                Console.WriteLine($"Is \"{input}\" what you intended? [Yes or No]");
                string confirmation = Console.ReadLine();
                if (confirmation.ToLower().StartsWith("y"))
                {
                    //Console.WriteLine("You wrote " + input);
                    stopLoop = true;
                }
                else if (confirmation.ToLower().StartsWith("n"))
                {

                }
                else
                {
                    Console.WriteLine("Invalid input, try again");

                }
            } while (!stopLoop);
            return input;
        }
        public static double GetUserInputAsDouble(string message)
        {
            double input = double.NaN;
            //bool success = double.TryParse(Console.ReadLine(), out input);
            //Validate Choice Range

            while (input is double.NaN)
            {
                Console.WriteLine(message);
                //Console.WriteLine("Invalid Input [bad choice]", true);
                var success = double.TryParse(Console.ReadLine(), out input);
                if (!success)
                {
                    input = double.NaN;
                    continue;
                }
                bool correctValue = ValidateInput($"Is {input} the correct number? y/n");
                if (!correctValue)
                {
                    input = double.NaN;
                    continue;
                }
            }
            return input;
        }
        public static int GetUserInputAsInt(string message)
        {
            int input = int.MinValue;
            //bool success = int.TryParse(Console.ReadLine(), out input);
            //Validate Choice Range

            while (input is int.MinValue)
            {
                Console.WriteLine(message);
                //Console.WriteLine("Invalid Input [bad choice]", true);
                var success = int.TryParse(Console.ReadLine(), out input);
                if (!success)
                {
                    input = int.MinValue;
                    continue;
                }
                bool correctValue = ValidateInput($"Is {input} the correct number? y/n");
                if (!correctValue)
                {
                    input = int.MinValue;
                    continue;
                }
            }
            return input;
        }
        private static bool ValidateInput(string message)
        {
            Console.WriteLine(message);
            var choice = Console.ReadLine();
            return choice != null && choice.ToLower().StartsWith('y');
        }
    }
}
