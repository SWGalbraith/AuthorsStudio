using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsStudio.IO.Windows
{
    internal static class FileStorageUtils
    {
        // TODO: Implement this class

        internal static string GetApplicationInstallPath()
        {
            return Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
        }
    }
}
