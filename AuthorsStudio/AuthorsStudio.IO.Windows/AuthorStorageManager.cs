using AuthorsStudio.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AuthorsStudio.Models;
using System.IO;

namespace AuthorsStudio.IO.Windows
{
    public class AuthorStorageManager : IAuthorStorageManager
    {
        private static string AuthorDetailsFilepath = 
            FileStorageUtils.GetApplicationInstallPath() + Path.PathSeparator + "AuthorDetails.json";

        private string _fileContent;

        public AuthorStorageManager()
        {
            if (File.Exists(AuthorDetailsFilepath))
            {
                _fileContent = File.ReadAllText(AuthorDetailsFilepath);
            }
            else
            {
                _fileContent = null;
            }
        }

        public void AddAuthor(IAuthor author)
        {
            throw new NotImplementedException();

            SaveAuthorsStorageFile();
        }

        public void DeleteAuthor(IAuthor author)
        {
            throw new NotImplementedException();

            SaveAuthorsStorageFile();
        }

        public List<IAuthor> GetStoredAuthorsList()
        {
            return GetStoredAuthorsList(AuthorDetailsFilepath);
        }

        public void ImportAuthorsFromStorageFile(FileInfo authorsStorageFile)
        {
            List<IAuthor> importedAuthorsList = GetStoredAuthorsList(authorsStorageFile.FullName);

            foreach (IAuthor author in importedAuthorsList)
            {
                AddAuthor(author);
            }

            SaveAuthorsStorageFile();
        }

        public void UpdateAuthor(IAuthor previousAuthor, IAuthor updatedAuthor)
        {
            foreach (IAuthor author in GetStoredAuthorsList())
            {
                if (author.Equals(previousAuthor))
                {
                    author.Address = updatedAuthor.Address;
                    author.ContactNumbersList = updatedAuthor.ContactNumbersList;
                    author.EmailAddress = updatedAuthor.EmailAddress;
                    author.Name = updatedAuthor.Name;
                }
            }

            SaveAuthorsStorageFile();
        }

        private List<IAuthor> GetStoredAuthorsList(string filepath)
        {
            throw new NotImplementedException();

            string authorFileContents = null;

            // Get the content and turn it into IAuthor objects

            SaveAuthorsStorageFile();
        }

        private void SaveAuthorsStorageFile()
        {
            File.WriteAllText(AuthorDetailsFilepath, _fileContent);
        }
    }
}
