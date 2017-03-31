using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsStudio.Models
{
    public interface INote
    {
        String getTitle { get; set; }

        String getContent { get; set; }

        IProject getParentProject { get; }

        IChapter getParentChapter { get; }
    }
}
