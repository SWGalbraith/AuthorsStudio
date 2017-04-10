using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsStudio.IO.Interfaces
{
    public interface ICompressor
    {
        string CompressString(string text);

        string DecompressString(string compressedText);
    }
}
