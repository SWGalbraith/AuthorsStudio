using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsStudio.Models
{
    public class Note : INote
    {
        #region Private Properties

        private Guid _noteId;
        private string _content;
        private IChapter _parentChapter;
        private IProject _parentProject;
        private string _title;

        #endregion

        #region Public Properties

        public Guid NoteId
        {
            get { return _noteId; }
        }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        public IChapter ParentChapter
        {
            get { return _parentChapter; }
        }

        public IProject ParentProject
        {
            get { return _parentProject; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        #endregion

        #region Constructors

        public Note(Guid noteId, string title, string content, IProject parentProject)
        {
            _noteId = noteId;
            _title = title;
            _content = content;
            _parentProject = parentProject;
        }

        public Note(Guid noteId, string title, string content, IChapter parentChapter)
        {
            _noteId = noteId;
            _title = title;
            _content = content;
            _parentChapter = parentChapter;
        }

        #endregion

        #region Public Static Methods

        public static INote CreateNewProjectNote(string title, string content, IProject parentProject)
        {
            return new Note(Guid.NewGuid(), title, content, parentProject);
        }

        public static INote CreateNewChapterNote(string title, string content, IChapter parentChapter)
        {
            return new Note(Guid.NewGuid(), title, content, parentChapter);
        }

        #endregion
    }
}
