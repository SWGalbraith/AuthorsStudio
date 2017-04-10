using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AuthorsStudio.Models
{
    public class Chapter : IChapter
    {
        #region Private Properties

        private Guid _chapterId;
        private IAuthor _author;
        private List<INote> _chapterNotesList;
        private string _content;
        private int _index;
        private IProject _parentProject;
        private string _subtitle;
        private string _title;
        private int _wordCount;

        #endregion

        #region Public Properties

        public Guid ChapterId
        {
            get { return _chapterId; }
        }

        public IAuthor Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public List<INote> ChapterNotesList
        {
            get { return _chapterNotesList; }
        }

        public string Content
        {
            get { return _content; }
            set { _content = value; }
        }

        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }

        public IProject ParentProject
        {
            get { return _parentProject; }
            set { _parentProject = value; }
        }

        public string Subtitle
        {
            get { return _subtitle; }
            set { _subtitle = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public int WordCount
        {
            get { return GetWordCount(); }
        }

        #endregion

        #region Constructor

        public Chapter(Guid chapterId, int index, IAuthor author, string title, string subtitle, 
            string content, List<INote> chapterNotesList, IProject parentProject)
        {
            _chapterId = chapterId;
            _index = index;
            _author = author;
            _title = title;
            _subtitle = subtitle;
            _content = content;
            _chapterNotesList = chapterNotesList;
            _parentProject = parentProject;
        }

        #endregion

        #region Private Methods

        private int GetWordCount()
        {
            MatchCollection wordCollection = Regex.Matches(_content, @"[\S]+");
            return wordCollection.Count;
        }

        #endregion

        #region Public Methods

        public void AddChapterNote(INote note)
        {
            _chapterNotesList.Add(note);
        }

        public void DeleteChapterNote(string noteTitle)
        {
            foreach (INote note in _chapterNotesList)
            {
                if (note.Title == noteTitle)
                {
                    _chapterNotesList.Remove(note);
                    break;
                }
            }
        }

        public void DeleteChapterNote(INote note)
        {
            _chapterNotesList.Remove(note);
        }

        public void UpdateChapterNote(INote updatedNote)
        {
            foreach (INote note in _chapterNotesList)
            {
                if (note.NoteId == updatedNote.NoteId)
                {
                    note.Title = updatedNote.Title;
                    note.Content = updatedNote.Content;
                    break;
                }
            }
        }

        #endregion

        #region Public Static Methods

        public static IChapter CreateNewChapter(int index, IAuthor author, string title, string subtitle,
            string content, List<INote> chapterNotesList, IProject parentProject)
        {
            return new Chapter(Guid.NewGuid(), index, author, title, subtitle, content, chapterNotesList, parentProject);
        }

        #endregion
    }
}
