using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsStudio.Models
{
    public class Note : INote
    {
        public Guid NoteId
        {
            get
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

        public IChapter ParentChapter
        {
            get
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
    }
}
