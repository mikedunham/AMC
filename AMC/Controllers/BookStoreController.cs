using AMC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AMC.Controllers
{
    [RoutePrefix("api/bookstore")]
    public class BookStoreController : ApiController
    {

        
        IBookRepository _bookRepo;

        public BookStoreController()
        {
            _bookRepo = new BookRepository();
        } 

        [HttpGet, Route("{id}", Name = "GetBookById")]
        public IHttpActionResult Get(int id)
        {
            var book = _bookRepo.GetBook(id);
            if (book == default(Book))
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpGet, Route("")]
        public IHttpActionResult Get()
        {
            var books = _bookRepo.GetBooks().Select(b =>
            {                
                b.AddLinks(CreateLinks(b));
                return b;
            });

            return Ok(books);
        }


        private IEnumerable<Link> CreateLinks(Book book)
        {
            var links = new[]
            {
        new Link
        {
            Method = "GET",
            Rel = "self",
            Href = Url.Link("GetBookById", new {id = book.Id})
        },
        new Link
        {
            Method = "GET",
            Rel = "get-author",
            Href = Url.Link("GetAuthorByBookId", new {id = book.Id})
        },
        new Link
        {
            Method = "GET",
            Rel = "get-category",
            Href = Url.Link("GetCategoryByBookId", new {id = book.Id})
        },
        new Link
        {
            Method = "GET",
            Rel = "get_reviews",
            Href = Url.Link("GetReviewsByBookId", new {id = book.Id})
        }
            };
            return links;
        }

    }
}
