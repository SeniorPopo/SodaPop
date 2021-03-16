using System;

namespace Soda
{
    // This Program Pops open an imaginary crisp soda.
    class Program
    {
        static void Main(string[] args)
        {
            //case integer
            int caseSwitch = 0;
            
            // Ask User What They Would Like
            Console.WriteLine("Na-ni ga shimasu ka?");
            Console.WriteLine("1. Coke \r\n2. Sprite \r\n3. Pepsi \r\n4. RootBeer");
            Console.Write("Enter: ");
            // Convert User Input To Int for case statement
            caseSwitch = Convert.ToInt32(Console.ReadLine());
            
            switch (caseSwitch)
            {
                case 1:
                    Pop("Coke");
                    break;
                case 2:
                    Pop("Sprite");
                    break;
                case 3:
                    Pop("Pepsi");
                    break;
                case 4:
                    Pop("RootBeer");
                    break;
                    // Catch incorrect user input.
                default:
                    Console.WriteLine("Sorry there is no soda corresponding to that number.");
                    break;
            }


        }

        // Method for display message.
        static void Pop(string colaName)
        {
            Console.WriteLine("You Pop the " + colaName + "'s cap");
           
            
        }
    }
}
