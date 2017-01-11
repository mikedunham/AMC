using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMC.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string PublishDate { get; set; }

        public string CoverImageUrl { get; set; }

        public IEnumerable<Link> Links;

        public IEnumerable<Link> AddLinks()
        {
            throw new NotImplementedException();
        }
    }
}