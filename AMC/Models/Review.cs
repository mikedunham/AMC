using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMC.Models
{
    public class Review
    {
        public int Id { get; set; }

        public int BookId { get; set; }

        public string ReviewerName { get; set; }

        public string ReviewText { get; set; }

        public int Rating { get; set; }

        public string PublishDate { get; set; }
    }
}