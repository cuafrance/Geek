using System;
using System.Runtime.Serialization;

namespace PersoGeek.WcfService.Objects
{
    [DataContract]
    public class BookData
    {
        public BookData(int? bookId, string title, string author, string categoryName, DateTime publishDate)
        {
            BookId = bookId;
            Title = title;
            Author = author;
            CategoryName = categoryName;
            PublishDate = publishDate;
        }
        [DataMember]
        public int? BookId { get; set; }
        [DataMember]
        public string Title { get; set; }
        [DataMember]
        public string Author { get; set; }
        [DataMember]
        public string CategoryName { get; set; }
        [DataMember]
        public DateTime PublishDate { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        protected bool Equals(BookData other)
        {
            return string.Equals(Title, other.Title) && string.Equals(Author, other.Author);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return ((Title != null ? Title.GetHashCode() : 0) * 397) ^ (Author != null ? Author.GetHashCode() : 0);
            }
        }
    }
}
