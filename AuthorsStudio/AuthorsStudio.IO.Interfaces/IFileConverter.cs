using AuthorsStudio.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsStudio.IO.Interfaces
{
    public interface IFileConverter
    {
        FileInfo ConvertProject(IProject project);
    }
}
