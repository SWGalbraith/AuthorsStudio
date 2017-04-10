using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsStudio.Models
{
    public interface IChapter
    {
        Guid ChapterId { get; }

        int Index { get; set; }

        string Title { get; set; }

        string Subtitle { get; set; }

        string Content { get; set; }

        int WordCount { get; }

        IAuthor Author { get; set; }

        IProject ParentProject { get; set; }

        List<INote> ChapterNotesList { get; }

        void AddChapterNote(INote note);

        void UpdateChapterNote(INote note);

        void DeleteChapterNote(INote note);

        void DeleteChapterNote(string noteTitle);
    }
}
