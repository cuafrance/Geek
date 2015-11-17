using System;
using System.Collections.Generic;
using System.Linq;
using PersoGeek.WcfService.Objects;

namespace PersoGeek.WcfService.DataAccess
{
    public class BookRepository : IBookRepository
    {
        //TODO: ConcurrentCollection
        private readonly List<BookData> _bookList;

        public BookRepository(List<BookData> bookList = null)
        {
            if (bookList == null || !bookList.Any())
            {
                bookList = GetAll();
            }
            _bookList = bookList;
        }

        private static List<BookData> GetAll()
        {
            var list = new List<BookData>()
            {
                new BookData(1,"Hello Kaka", "Kaka", "Comedy",new DateTime(2008, 10, 25)),
                new BookData(2,"Hello Kaki", "Kaka", "Comedy",new DateTime(2008, 09, 25)),
                new BookData(3,"Hello Kiki", "Kaka", "Comedy",new DateTime(2008, 08, 25)),
                new BookData(4,"Goodbye Kaka", "Kaka", "Drama",new DateTime(2008, 10, 25)),
                new BookData(5,"Goodbye Kaki", "Kaka", "Drama",new DateTime(2008, 09, 25)),
                new BookData(6,"Goodbye Kiki", "Kaka", "Drama",new DateTime(2008, 08, 25)),
            };
            return list;
        }

        public List<BookData> Find(string keyword = null)
        {
            return String.IsNullOrEmpty(keyword) ? _bookList : Search(keyword);
        }

        private List<BookData> Search(string keyword)
        {
            if (_bookList == null || !_bookList.Any())
            {
                return null;
            }
            return _bookList.Where(x => IsMatch(x, keyword)).ToList();
        }

        private static bool IsMatch(BookData book, string keyword)
        {
            var keywordInUpper = keyword.ToUpper();
            return book.Author.ToUpper().Contains(keywordInUpper)
                   || book.Title.ToUpper().Contains(keywordInUpper)
                   || book.CategoryName.ToUpper().Contains(keywordInUpper);
        }

        public bool Add(BookData book)
        {
            if (book == null)
                return false;
            if (!book.BookId.HasValue)
            {
                book.BookId = GetNextId();
            }
            _bookList.Add(book);
            return true;
        }

        private int? GetNextId()
        {
            var tmp = _bookList.OrderByDescending(x => x.BookId).FirstOrDefault();
            var currentIndex = 0;
            if (tmp?.BookId != null)
            {
                currentIndex = tmp.BookId.Value;
            }
            return currentIndex + 1;


        }

        public bool Remove(BookData book)
        {
            return _bookList.Remove(book);
        }

        public BookData Update(BookData book)
        {
            return book;
        }
    }
}