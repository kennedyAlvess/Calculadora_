
namespace Calculator.Pages
{
    public class Pages
    {
        public static void HomePageRender()
        {
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("| Welcome to the Calculator! |");
            Console.WriteLine("=====================================");

            Console.WriteLine("------        Operations        -----");
            Console.WriteLine("1. Addition +      \t2. Subtraction -");
            Console.WriteLine("3. Multiplication *\t4. Division / ");
            Console.WriteLine("-----          0. Exit          -----");
        }

        public static void HeaderPageRender(int option)
        {   
            string Operation = GetOperation(option);
            Console.Clear();
            Console.WriteLine($"------\t {Operation} \t-----");
            Console.WriteLine("Press ESC for back to main menu.");
        }

        public static void ExitPageRender()
        {
            Console.Clear();
            Console.WriteLine("------\t Goodbye! \t-----");
            Console.ReadKey(true);
            Console.Clear();
        }

        private static string GetOperation(int option)
        {
            return option switch
            {
                1 => "Addition",
                2 => "Subtraction",
                3 => "Multiplication",
                4 => "Division",
                _ => "Invalid Operation",
            };
        }
    }
}

