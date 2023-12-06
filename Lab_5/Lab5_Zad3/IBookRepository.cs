﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Zad3
{

    public interface IBookRepository : IBaseRepository<Book, int>
    {
        IEnumerable<Book> GetBooksByAuthor(string author);
        IEnumerable<Book> GetBooksByYear(int year);
    }


}
