using Calculator.Pages;

namespace Calculator.Operations
{
    public class OperationServices
    {
        public static void Addition(int option)
        {
            
            double result = 0;
            ConsoleKeyInfo keyPress;

            do
            {
                Pages.Pages.HeaderPageRender(option);
                Console.WriteLine($"\nResult: {(result == 0? "": result)}\n");

                Console.Write("Enter a number: ");
                string input = Console.ReadLine()?? "";

                if (double.TryParse(input, out double number))
                {
                    result += number;
                    Pages.Pages.HeaderPageRender(option);
                    Console.WriteLine($"\nResult: {result}\n");
                    Console.WriteLine("-- Press any key to continue.");
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid number!");
                    Console.WriteLine("-- Press any key to continue.");
                }
                keyPress = Console.ReadKey(true);
            }
            while (keyPress.Key != ConsoleKey.Escape);
        }
    }

}