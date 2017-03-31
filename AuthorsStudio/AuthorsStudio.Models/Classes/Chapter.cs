using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsStudio.Models
{
    public class Chapter : IChapter
    {
        public Guid ChapterId
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IAuthor Author
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public List<INote> ChapterNotesList
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Content
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public int Index
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public IProject ParentProject
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Subtitle
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Title
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string WordCount
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void AddChapterNote(INote note)
        {
            throw new NotImplementedException();
        }

        public void DeleteChapterNote(string noteTitle)
        {
            throw new NotImplementedException();
        }

        public void DeleteChapterNote(INote note)
        {
            throw new NotImplementedException();
        }

        public void UpdateChapterNote(INote note)
        {
            throw new NotImplementedException();
        }
    }
}
