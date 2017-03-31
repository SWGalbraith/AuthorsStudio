using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsStudio.Models
{
    public interface IProject
    {
        string Title { get; set; }

        string ImagePath { get; set; }

        FileInfo ProjectFile { get; set; }

        DateTime CreationDate { get; set; }

        DateTime ProjectDeadline { get; set; }

        IAuthor Author { get; set; }

        List<IChapter> Chapters { get; }

        List<INote> Notes { get; }
    }
}
