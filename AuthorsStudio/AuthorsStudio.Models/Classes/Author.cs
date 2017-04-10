using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsStudio.Models
{
    public class Author : IAuthor
    {
        #region Private Properties

        private Guid _authorId;
        private IAddress _address;
        private List<IProject> _associatedProjectsList;
        private List<string> _contactNumbersList;
        private string _emailAddress;
        private string _name;

        #endregion

        #region Public Properties

        public Guid AuthorId
        {
            get { return _authorId; }
        }

        public IAddress Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public List<IProject> AssociatedProjectsList
        {
            get { return _associatedProjectsList; }
        }

        public List<string> ContactNumbersList
        {
            get { return _contactNumbersList; }
            set { _contactNumbersList = value; }
        }

        public string EmailAddress
        {
            get { return _emailAddress; }
            set { _emailAddress = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        #endregion

        #region Constructor

        public Author(Guid authorId, string name, string emailAddress, IAddress address, 
            List<string> contactNumbersList, List<IProject> associatedProjectsList)
        {
            _authorId = authorId;
            _name = name;
            _emailAddress = emailAddress;
            _address = address;
            _contactNumbersList = contactNumbersList;
            _associatedProjectsList = associatedProjectsList;
        }

        #endregion

        #region Public Methods

        public void AddAssociatedProject(IProject project)
        {
            _associatedProjectsList.Add(project);
        }

        public void AddContactNumber(string contactNumber)
        {
            _contactNumbersList.Add(contactNumber);
        }

        #endregion

        #region Public Static Methods

        public static Author CreateNewAuthor(string name, string emailAddress, IAddress address,
            List<string> contactNumbersList, List<IProject> associatedProjectsList)
        {
            return new Author(Guid.NewGuid(), name, emailAddress, address, contactNumbersList, associatedProjectsList);
        }

        #endregion
    }
}
