using AuthorsStudio.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsStudio.IO.Interfaces
{
    public interface IAuthorStorageManager
    {
        void AddAuthor(IAuthor author);

        void UpdateAuthor(IAuthor previousAuthor, IAuthor updatedAuthor);

        void DeleteAuthor(IAuthor author);

        List<IAuthor> GetStoredAuthorsList();

        void ImportAuthorsFromStorageFile(FileInfo authorsStorageFile);
    }
}
