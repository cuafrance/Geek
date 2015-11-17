using System.Collections.Generic;
using PersoGeek.WcfService.Objects;

namespace PersoGeek.WcfService.DataAccess
{
    public interface IBookRepository
    {
        List<BookData> Find(string keyword = null);
        bool Add(BookData book);
        bool Remove(BookData book);
        BookData Update(BookData book);
    }
}