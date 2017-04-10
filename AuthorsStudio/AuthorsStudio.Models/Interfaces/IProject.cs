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
        Guid ProjectId { get; }

        string Title { get; set; }

        string ImagePath { get; set; }

        FileInfo ProjectFile { get; set; }

        DateTime CreationDate { get; }

        DateTime ProjectDeadline { get; set; }

        IAuthor Author { get; set; }

        List<IChapter> Chapters { get; }

        List<INote> Notes { get; }

        void AddChapter(IChapter chapter);

        void UpdateChapter(IChapter chapter);

        void DeleteChapter(IChapter chapter);

        void DeleteChapter(string chapterTitle);

        void AddChapterNote(INote note);

        void UpdateChapterNote(INote note);

        void DeleteChapterNote(INote note);

        void DeleteChapterNote(string noteTitle);

        int GetDaysRemainingUntilDeadline();
    }
}
