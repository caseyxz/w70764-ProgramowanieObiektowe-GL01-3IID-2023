using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Zad3
{
 
    public class BookRepository : IBookRepository
    {
        private List<Book> books = new List<Book>();

        public void Create(Book entity)
        {
            entity.Id = books.Count + 1;
            books.Add(entity);
        }

        public void Update(Book entity)
        {
            var existingBook = books.Find(b => b.Id == entity.Id);
            if (existingBook != null)
            {
                existingBook.Title = entity.Title;
                existingBook.Author = entity.Author;
                existingBook.YearOfPublication = entity.YearOfPublication;
            }
        }

        public IEnumerable<Book> GetAll()
        {
            return books;
        }

        public Book Get(int id)
        {
            return books.Find(b => b.Id == id);
        }

        public void Delete(int id)
        {
            var bookToRemove = books.Find(b => b.Id == id);
            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
            }
        }

        public IEnumerable<Book> GetBooksByAuthor(string author)
        {
            return books.Where(b => b.Author == author);
        }

        public IEnumerable<Book> GetBooksByYear(int year)
        {
            return books.Where(b => b.YearOfPublication == year);
        }
    }


}
