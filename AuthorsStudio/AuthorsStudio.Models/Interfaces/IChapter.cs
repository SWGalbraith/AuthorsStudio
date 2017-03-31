using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsStudio.Models
{
    public interface IChapter
    {
        int Index { get; set; }

        String Title { get; set; }

        String Subtitle { get; set; }

        String Content { get; set; }

        String WordCount { get; set; }

        IAuthor Author { get; set; }

        IProject ParentProject { get; set; }

        List<INote> ChapterNotesList { get; set; }

        void AddChapterNote(INote note);

        void UpdateChapterNote(INote note);

        void DeleteChapterNote(INote note);

        void DeleteChapterNote(String noteTitle);
    }
}
