using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsStudio.Models
{
    public interface IAuthor
    {
        string Name { get; set; }

        IAddress Address { get; set; }

        string getEmailAddress { get; set; }

        List<string> getContactNumbersList { get; set; }

        List<IProject> getAssociatedProjectsList { get; }
    }
}
