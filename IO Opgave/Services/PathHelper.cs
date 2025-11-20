using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_Opgave.Services
{
    public class PathHelper
    {
        public static string GetProjectRoot()
        {
            // Returns the root location of the project
            return Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\.."));
        }
        public static string GetDataFolder()
        {
            // Returns absolute Data folder path
            return Path.Combine(GetProjectRoot(), "Data");
        }
    }
}
