using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorsStudio.Models
{
    public class Project : IProject
    {
        #region Private Properties

        private Guid _projectId;
        private IAuthor _author;
        private List<IChapter> _chaptersList;
        private DateTime _creationDate;
        private string _imagePath;
        private List<INote> _notesList;
        private DateTime _projectDeadline;
        private FileInfo _projectFile;
        private string _title;

        #endregion

        #region Public Properties

        public Guid ProjectId
        {
            get { return _projectId; }
        }

        public IAuthor Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public List<IChapter> Chapters
        {
            get { return _chaptersList; }
        }

        public DateTime CreationDate
        {
            get { return _creationDate; }
        }

        public string ImagePath
        {
            get { return _imagePath; }
            set { _imagePath = value; }
        }

        public List<INote> Notes
        {
            get { return _notesList; }
        }

        public DateTime ProjectDeadline
        {
            get { return _projectDeadline; }
            set { _projectDeadline = value; }
        }

        public FileInfo ProjectFile
        {
            get { return _projectFile; }
            set { _projectFile = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        #endregion

        #region Constructor

        public Project(Guid projectId, string title, IAuthor author, DateTime creationDate, DateTime projectDeadline, 
            List<IChapter> chaptersList, List<INote> notesList, string imagePath, FileInfo projectFile)
        {
            _projectId = projectId;
            _title = title;
            _author = author;
            _creationDate = creationDate;
            _projectDeadline = projectDeadline;
            _chaptersList = chaptersList;
            _notesList = notesList;
            _imagePath = imagePath;
            _projectFile = projectFile;
        }

        #endregion

        #region Public Methods

        public void AddChapter(IChapter chapter)
        {
            _chaptersList.Add(chapter);
        }

        public void UpdateChapter(IChapter updatedChapter)
        {
            foreach (IChapter chapter in _chaptersList)
            {
                if (chapter.ChapterId == updatedChapter.ChapterId)
                {
                    chapter.Title = chapter.Title;
                    chapter.Subtitle = updatedChapter.Subtitle;
                    chapter.Content = updatedChapter.Content;
                    chapter.Author = updatedChapter.Author;
                    chapter.Index = updatedChapter.Index;
                    chapter.ParentProject = updatedChapter.ParentProject;

                    break;              
                }
            }
        }

        public void DeleteChapter(IChapter chapter)
        {
            _chaptersList.Remove(chapter);
        }

        public void DeleteChapter(string chapterTitle)
        {
            foreach (IChapter chapter in _chaptersList)
            {
                if (chapter.Title == chapterTitle)
                {
                    _chaptersList.Remove(chapter);
                    break;
                }
            }
        }

        public void AddChapterNote(INote note)
        {
            _notesList.Add(note);
        }

        public void DeleteChapterNote(string noteTitle)
        {
            foreach (INote note in _notesList)
            {
                if (note.Title == noteTitle)
                {
                    _notesList.Remove(note);
                    break;
                }
            }
        }

        public void DeleteChapterNote(INote note)
        {
            _notesList.Remove(note);
        }

        public void UpdateChapterNote(INote updatedNote)
        {
            foreach (INote note in _notesList)
            {
                if (note.NoteId == updatedNote.NoteId)
                {
                    note.Title = updatedNote.Title;
                    note.Content = updatedNote.Content;
                    break;
                }
            }
        }

        public int GetDaysRemainingUntilDeadline()
        {
            return (int)(_projectDeadline - _creationDate).TotalDays;
        }

        #endregion

        #region Public Static Methods

        public static IProject CreateNewProject(string title, IAuthor author, DateTime projectDeadline,
            List<IChapter> chaptersList, List<INote> notesList, string imagePath, FileInfo projectFile)
        {
            return new Project(Guid.NewGuid(), title, author, DateTime.Now, projectDeadline, chaptersList, notesList, imagePath, projectFile);
        }

        #endregion
    }
}
