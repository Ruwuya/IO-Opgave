using System.Collections.Generic;
using System.IO;

namespace IO_Opgave.Services
{
    public static class FileTraversalService
    {
        public static IEnumerable<string> DepthFirstGetTxtLines(string startFolder)
        {
            // First go through all subdirectories (DFS)
            foreach (var directory in Directory.GetDirectories(startFolder))
            {
                // Gets every line from a subfolder
                foreach (var line in DepthFirstGetTxtLines(directory))
                {
                    yield return line;
                }
            }

            // Then handle all .txt files in the current folder
            foreach (var file in Directory.GetFiles(startFolder, "*.txt"))
            {
                // Reading every line
                foreach (var line in File.ReadAllLines(file))
                {
                    yield return line;
                }
            }
        }
    }
}
