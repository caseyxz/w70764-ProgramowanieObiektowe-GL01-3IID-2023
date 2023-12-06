using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Zad3
{
    public class Person : IEntity<int>, ICreationDate
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Book> BorrowedBooks { get; set; }
        public DateTime CreationDate { get; set; }
    }

}
