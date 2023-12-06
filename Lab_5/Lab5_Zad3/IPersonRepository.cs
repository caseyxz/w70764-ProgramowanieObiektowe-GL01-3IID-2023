using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Zad3
{

    public interface IPersonRepository : IBaseRepository<Person, int>
    {
        IEnumerable<Book> GetBorrowedBooks(int personId);
        void AddBorrowedBook(int personId, Book book);
    }


}
