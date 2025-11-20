using IO_Opgave.Assignments;

namespace IO_Opgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            // Using a while loop
            while (true)
            {
                Console.Clear();
                Console.WriteLine("IO Assignment");
                Console.WriteLine("1. Assignment 1 (Basic)");
                Console.WriteLine("2. Assignment 2 (Advanced)");
                Console.WriteLine("3. Assignment 3 (Expert)");
                Console.WriteLine("0. Exit");
                Console.Write("Choose: ");

                var choice = Console.ReadLine();

                // Simple switch statement to be able to run each assignment independantly
                switch (choice)
                {
                    case "1":
                        Assignment01.Run();
                        break;
                    case "2":
                        Assignment02.Run();
                        break;
                    case "3":
                        Assignment03.Run();
                        break;
                    case "0" or "q" or "quit":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Press Enter...");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
