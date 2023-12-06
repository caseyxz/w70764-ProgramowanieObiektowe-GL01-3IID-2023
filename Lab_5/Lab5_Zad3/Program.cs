using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Zad3
{
    class Program
    {
        static void Main()
        {
            
            IBookRepository bookRepository = new BookRepository();
            IPersonRepository personRepository = new PersonRepository();

            // Dodanie książki
            Book newBook = new Book
            {
                Title = "Sample Book",
                Author = "Sample Author",
                YearOfPublication = 2022,
                CreationDate = DateTime.Now
            };

            bookRepository.Create(newBook);

            // Pobranie i wyświetlenie wszystkich książek
            var allBooks = bookRepository.GetAll();
            foreach (var book in allBooks)
            {
                Console.WriteLine($"Book Id: {book.Id}, Title: {book.Title}, Author: {book.Author}");
            }

            // Dodanie osoby i wypożyczenie książki
            Person newPerson = new Person
            {
                FirstName = "John",
                LastName = "Doe",
                Age = 30,
                CreationDate = DateTime.Now
            };

            personRepository.Create(newPerson);

            personRepository.AddBorrowedBook(newPerson.Id, newBook);

            // Pobranie i wyświetlenie wypożyczonych książek przez osobę
            var borrowedBooks = personRepository.GetBorrowedBooks(newPerson.Id);
            Console.WriteLine($"Books borrowed by {newPerson.FirstName} {newPerson.LastName}:");
            foreach (var borrowedBook in borrowedBooks)
            {
                Console.WriteLine($"Book Id: {borrowedBook.Id}, Title: {borrowedBook.Title}, Author: {borrowedBook.Author}");
            }

            Console.ReadKey();
        }
    
    }

}
