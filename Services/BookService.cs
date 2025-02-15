using BookApi.Models;
using System.Linq;
using System.Collections.Generic;
using System.Data.Common;

namespace BookApi.Services //Handes the business logic 
{
    class BookService
    {
        private static List<Book> books = new List<Book>()
        {
            new Book (1, "A filha do Capitão", "José Rodrigues Dos Santos", 2009),
            new Book (2, "O ensaio sobre a Cegueira", "José Saramago", 1995)

        };

        //Get a book by its id
        public Book GetBookById(int id)
        {
            return books.Find(book => book.Id == id);
        }

        //Get all books
        public List<Book> GetAll() => books;

        //Add a book
        public void AddBook(Book book) => books.Add(book);

        //Update a book
        public bool Update(int id, Book updateBook){

            var book = books.Find(book => book.Id == id);
            if(book == null) return false;

            book.Name = updateBook.Name;
            book.Author = updateBook.Author;
            book.YearReleased = updateBook.YearReleased;

            return true;
        }

        //delete a book
        public bool Delete(int id){
            var book = books.Find(book => book.Id == id);
            if(book == null) return false;

        
            books.Remove(book);
            return true;        
            }
    }
}