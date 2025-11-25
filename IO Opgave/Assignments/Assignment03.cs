using IO_Opgave.Services;

namespace IO_Opgave.Assignments
{
    public class Assignment03
    {
        public static void Run()
        {
            // A program that automatically finds a route to traverse in a directory structure
            // then text is put together to one file.

            // Asks user for absolute path or automatically finds path
            Console.WriteLine("Leave empty to automatically find root or,");
            Console.WriteLine("Please write the absolute path of the directory you want to traverse: ");
            string? userRootPath = Console.ReadLine();

            string startFolder;

            // If the user input is empty, default to 'Data' folder
            // otherwise use the path that the user wrote
            if (string.IsNullOrWhiteSpace(userRootPath))
            {
                startFolder = PathHelper.GetDataFolder();
            }
            else
            {
                startFolder = userRootPath;
            }

            // Uses DFS service to get all lines from .txt files
            var lines = FileTraversalService.DepthFirstGetTxtLines(startFolder);
            string sentence = string.Join(" ", lines);

            // Shows which path it took
            PrintTree(startFolder, 0);

            Console.WriteLine("Combined text from all .txt files: ");
            Console.WriteLine(sentence + "\n");

            // Old test (Temporary)
            Console.WriteLine("Herro assignment 3");

            // Waiting for user input before returning to menu
            Console.WriteLine("Press enter to return to the menu...");
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