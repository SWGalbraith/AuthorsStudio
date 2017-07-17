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
    public class ProjectStorageManager : IProjectStorageManager
    {
        // TODO: Finish this class

        private static string ProjectDetailsFilepath =
            FileStorageUtils.GetApplicationInstallPath() + Path.PathSeparator + "ProjectDetails.json";

        private string _fileContent;

        public ProjectStorageManager()
        {
            if (File.Exists(ProjectDetailsFilepath))
            {
                _fileContent = File.ReadAllText(ProjectDetailsFilepath);
            }
            else
            {
                _fileContent = null;
            }
        }

        public void DeleteProject(IProject project)
        {
            throw new NotImplementedException();
        }

        public bool DoesProjectAlreadyExist(string projectTitle)
        {
            throw new NotImplementedException();
        }

        public IProject GetProject(string projectTitle)
        {
            throw new NotImplementedException();
        }

        public IProject GetProjectFromFile(string filepath)
        {
            throw new NotImplementedException();
        }

        public List<IProject> GetStoredProjectsList()
        {
            throw new NotImplementedException();
        }

        public void ImportProjectsFromStorageFile(FileInfo projectStorageFile)
        {
            throw new NotImplementedException();
        }

        public void SaveProject(IProject project)
        {
            SaveProject(project, ProjectDetailsFilepath);
        }

        public void SaveProject(IProject project, string filepath)
        {
            AddToProjectsListFile(project);
            File.WriteAllText(filepath, _fileContent);
        }

        private void AddToProjectsListFile(IProject project)
        {
            throw new NotImplementedException();
        }
    }
}
