using AuthorsStudio.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsStudio.IO.Interfaces
{
    public interface IProjectStorageManager
    {
        void SaveProject(IProject project);

        void SaveProject(IProject project, string filepath);
        
        void DeleteProject(IProject project);
        
        List<IProject> GetStoredProjectsList();
        
        IProject GetProject(string projectTitle);
        
        bool DoesProjectAlreadyExist(string projectTitle);
        
        void ImportProjectsFromStorageFile(FileInfo projectStorageFile);
    }
}
