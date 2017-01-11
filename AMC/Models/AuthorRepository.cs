using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMC.Models
{
    public class AuthorRepository : IAuthorRepository
    {
        private List<Author> _authors;

        public AuthorRepository()
        {
            _authors = new List<Author>
            {
                new Author { Id = 1, BookId = 3, FirstName = "Stephen", LastName = "King", HeadShotUrl = "http://stephenking.com/images/press/stephen_king.jpg"},
                new Author { Id = 2, BookId = 2, FirstName = "J.K.", LastName = "Rowling", HeadShotUrl = "http://jkrowling.com/wp-content/uploads/2016/12/JKROWLINGPR_S01_00057_V4.jpg"},
                new Author { Id = 3, BookId = 1, FirstName = "James", LastName = "Patterson", HeadShotUrl = "http://www.jamespatterson.com/images/JamesPatterson-creditSueSoliePatterson.jpg"},
                new Author { Id = 4, BookId = 4, FirstName = "Brian", LastName = "Freeman", HeadShotUrl = "http://bfreemanbooks.com/wp-content/uploads/2013/04/Screenshot-2016-10-04-08.25.36-300x231.png"},
                new Author { Id = 5, BookId = 5, FirstName = "Lee", LastName = "Child", HeadShotUrl = "http://www.leechild.com/images/uploads/2012/08/author-photo.jpg"}
            };
        }


        public Author GetAuthorByBookId(int id)
        {
            return _authors.Find(x => x.BookId == id);
        }

        public IEnumerable<Author> GetAuthors()
        {
            return _authors;
        }
    }
}