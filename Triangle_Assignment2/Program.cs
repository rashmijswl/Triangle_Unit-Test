using System;

namespace Triangle_Assignment2
{
    class Program
    {
        public static int validation_input(string input,string type)
        {
            int number;
            bool correct = false;            
            do
            {
                correct = int.TryParse(input, out number);
                if (correct == false)
                {
                    Console.WriteLine("Invalid input. {0}", type);
                    input = Console.ReadLine();
                }
            } while (correct == false);
            return number;
        }
        static void Main(string[] args)
        {
            TriangleSolver obj = new TriangleSolver();
            int valid_input = 0, choice =0;
            do
            {
                Console.WriteLine("Please choose:\n1.Enter Triangle Dimention\n2.Exit");
                choice = Program.validation_input(Console.ReadLine(), "Please choose from:\n1.Enter Triangle Dimention\n2.Exit");
                if(choice == 1)
                {
                    Console.WriteLine("Enter first side:");
                    int a = Program.validation_input(Console.ReadLine(), "Enter first side");
                    Console.WriteLine("Enter second side:");
                    int b = Program.validation_input(Console.ReadLine(), "Enter second side");
                    Console.WriteLine("Enter third side:");
                    int c = Program.validation_input(Console.ReadLine(), "Enter third side");
                    string triangle_type = obj.Analyze(a, b, c);
                    if(triangle_type == "Not a Triangle")
                    {
                        Console.WriteLine("The entered sides does not form a triangle");
                    }
                    else
                    {
                        Console.WriteLine("The enter side forms a triangle of type: \"{0}\"\n", triangle_type);
                    }
                }
                else if (choice == 2)
                {
                    valid_input = 1;
                }
                else
                {
                    Console.WriteLine("Please enter valid input");
                }
            } while (valid_input == 0);
        }
    }
}
