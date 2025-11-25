using IO_Opgave.Services;

namespace IO_Opgave.Assignments
{
    public class Assignment02
    {
        public static void Run()
        {
            Console.WriteLine("Herro assignemnt 2"); // Just tests (temporary)
            Console.WriteLine("please run this.."); // Just tests (temporary)
            // The 'Data' folder contains several subdirectories starting in 'Folder01'
            // Traverse the entire directory and extract all text from any .txt file
            // Then show all the text in the console

            Console.Clear();
            Console.WriteLine("Assignment 2 (Advanced)");
            Console.WriteLine();

            // Starting point for the traversal
            string rootFolder = Path.Combine(PathHelper.GetDataFolder(), "Folder01");

            Console.WriteLine($"Traversing from: {rootFolder}");
            Console.WriteLine();
            Console.WriteLine("Folder structure and .txt files:");
            Console.WriteLine();

            // Show which path we take through the folder structure
            PrintTree(rootFolder, 0);

            // Use your DFS (DepthFirstSearch) service to get all text lines from all .txt files
            var lines = FileTraversalService.DepthFirstGetTxtLines(rootFolder);

            // Combine all lines into one long sentence
            string sentence = string.Join(" ", lines);

            Console.WriteLine();
            Console.WriteLine("Combined sentence from all .txt files:");
            Console.WriteLine(sentence);
            Console.WriteLine();
            Console.WriteLine("Press Enter to return to the menu...");
            Console.ReadLine();
        }

        private static void PrintTree(string folder, int indentLevel)
        {
            // Printing the current folder name.
            string indent = new string(' ', indentLevel * 2);
            Console.WriteLine($"{indent}- {Path.GetFileName(folder)}");

            // Recursively print all subfolders
            foreach (var subDir in Directory.GetDirectories(folder))
            {
                // Increase indent for deeper levels
                PrintTree(subDir, indentLevel + 1);
            }

            // Print all .txt files in the current folder
            foreach (var file in Directory.GetFiles(folder, "*.txt"))
            {
                string fileIndent = new string(' ', (indentLevel + 1) * 2);
                Console.WriteLine($"{fileIndent}• {Path.GetFileName(file)}");
            }
        }
    }
}
