using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using BookApi.Models;
using BookApi.Services;

namespace BookApi.Controllers
{

    [Route("api/books")]
    [ApiController]
    public class BookController : ControllerBase
    {

        private readonly BookService _bookService = new BookService();


        //ActionResult is wrapper and a best practice using ASP.NET Web Api's to return response status (200, 400, 404, etc);

        [HttpGet]
        public ActionResult<List<Book>> GetAllBooks() => _bookService.GetAll();

        [HttpGet("{id}")]

        public ActionResult<Book> GetABookById(int id){

            var book = _bookService.GetBookById(id);
            return book == null ? NotFound() : Ok(book);
        }

        [HttpPost]
        public ActionResult<Book> Create(Book book){

            _bookService.AddBook(book);
            return CreatedAtAction(nameof(GetABookById), new { id = book.Id }, book);
        }
    }
}
