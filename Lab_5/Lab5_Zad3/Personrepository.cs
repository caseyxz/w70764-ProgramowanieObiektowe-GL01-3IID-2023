using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Zad3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PersonRepository : IPersonRepository
    {
        private List<Person> persons = new List<Person>();

        public void Create(Person entity)
        {
            entity.Id = persons.Count + 1;
            persons.Add(entity);
        }

        public void Update(Person entity)
        {
            var existingPerson = persons.Find(p => p.Id == entity.Id);
            if (existingPerson != null)
            {
                existingPerson.FirstName = entity.FirstName;
                existingPerson.LastName = entity.LastName;
                existingPerson.Age = entity.Age;
                existingPerson.BorrowedBooks = entity.BorrowedBooks;
            }
        }

        public IEnumerable<Person> GetAll()
        {
            return persons;
        }

        public Person Get(int id)
        {
            return persons.Find(p => p.Id == id);
        }

        public void Delete(int id)
        {
            var personToRemove = persons.Find(p => p.Id == id);
            if (personToRemove != null)
            {
                persons.Remove(personToRemove);
            }
        }

        public IEnumerable<Book> GetBorrowedBooks(int personId)
        {
            var person = persons.Find(p => p.Id == personId);
            return person?.BorrowedBooks ?? Enumerable.Empty<Book>();
        }

        public void AddBorrowedBook(int personId, Book book)
        {
            var person = persons.Find(p => p.Id == personId);
            if (person != null)
            {
                if (person.BorrowedBooks == null)
                {
                    person.BorrowedBooks = new List<Book>();
                }
                person.BorrowedBooks.Add(book);
            }
        }
    }

}
