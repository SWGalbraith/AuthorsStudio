﻿using System;
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

        void SaveProject(IProject project, String filepath);
        
        void DeleteProject(IProject project);
        
        List<IProject> GetStoredProjectsList();
        
        IProject GetProject(String projectTitle);
        
        boolean DoesProjectAlreadyExist(String projectTitle);
        
        void ImportProjectsFromStorageFile(FileInfo projectStorageFile);
    }
}
