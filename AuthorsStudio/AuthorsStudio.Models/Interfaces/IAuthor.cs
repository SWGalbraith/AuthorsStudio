using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsStudio.Models
{
    public interface IAuthor
    {
        Guid AuthorId { get; }

        string Name { get; set; }

        IAddress Address { get; set; }

        string EmailAddress { get; set; }

        List<string> ContactNumbersList { get; set; }

        List<IProject> AssociatedProjectsList { get; }
    }
}
