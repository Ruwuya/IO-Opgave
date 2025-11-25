using IO_Opgave.Services;

namespace IO_Opgave.Assignments
{
    public class Assignment01
    {
        public static void Run()
        {
            Console.WriteLine("Please pick which part of assingment 1 to run\nA.\nB.");
            var choice = Console.ReadLine();

            if (choice == "A" || choice == "a")
            {
                RunPartA();
            }
            else
            {
                RunPartB();
            }
        }

        public static void RunPartA()
        {
            // Writes a fixed string to a .txt file  in the 'Data' folder
            // The file is always overwritten and it is names "Assignment01SolutionA.txt"

            // Saving in the root folder (Data) and naming the file created
            string dataFolder = PathHelper.GetDataFolder();
            string filePath = Path.Combine(dataFolder, "Assignment01SolutionA.txt");

            // Overwritting the text in file
            File.WriteAllText(filePath, "Herro world! getattahere");
            

            // Showing user where file is saved
            Console.WriteLine($"File saved at: {filePath}");
            Console.ReadLine();
        }

        public static void RunPartB()
        {
            // Takes user input and appends the string to a .txt file in the 'Data' folder
            // The new text is always added to the end, and it doesn't overwrite the file just appends.
            Console.WriteLine("Write text to append:");
            string text = Console.ReadLine() ?? string.Empty;

            // Save location and naming the file
            string dataFolder = PathHelper.GetDataFolder();
            string filePath = Path.Combine(dataFolder, "Assignment01SolutionB.txt");

            // Append directly without overwriting
            File.AppendAllText(filePath, text + Environment.NewLine);

            Console.WriteLine($"Text appended to: {filePath}");
            Console.ReadLine();
        }
    }
}
