using AuthorsStudio.IO.Interfaces;
using AuthorsStudio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsStudio.IO.Windows
{
    public class FileConverterFactory : IFileConverterFactory
    {
        // Private constructor to implement the Singleton Factory Pattern
        private FileConverterFactory() { }

        public static FileConverterFactory getInstance()
        {
            return new FileConverterFactory();
        }

        public IFileConverter GetFileConverter(FileConverterType converterType)
        {
            IFileConverter fileConverter;

            switch (converterType)
            {
                case FileConverterType.Docx:
                    fileConverter = new DocxFileConverter();
                    break;
                case FileConverterType.Pages:
                    fileConverter = new PagesFileConverter();
                    break;
                case FileConverterType.Pdf:
                    fileConverter = new PdfFileConverter();
                    break;
                default:
                   fileConverter = null;
                    break;
            }

            return fileConverter;
        }
    }
}
