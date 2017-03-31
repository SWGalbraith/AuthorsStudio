using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsStudio.Models
{
    public interface INote
    {
        Guid NoteId { get; }

        string Title { get; set; }

        string Content { get; set; }

        IProject ParentProject { get; }

        IChapter ParentChapter { get; }
    }
}
