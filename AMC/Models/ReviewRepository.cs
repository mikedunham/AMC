using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMC.Models
{
    public class ReviewRepository : IReviewRepository
    {
        private List<Review> _reviews;

        public ReviewRepository()
        {
            _reviews = new List<Review> {
                new Review { Id = 1, BookId = 5, PublishDate = "06/04/2014", Rating = 5, ReviewerName= "John Smith", ReviewText = "This is my favorite book!" },
                new Review { Id = 2, BookId = 4, PublishDate = "08/04/2011", Rating = 4, ReviewerName= "Betty Douglas", ReviewText = "Decent suspenseful book" },
                new Review { Id = 3, BookId = 3, PublishDate = "06/12/2016", Rating = 3, ReviewerName= "Frank Dodge", ReviewText = "Book was OK, could have had a better ending." },
                new Review { Id = 4, BookId = 2, PublishDate = "05/09/2014", Rating = 4, ReviewerName= "Bill Clark", ReviewText = "Decent book with a great ending" },
                new Review { Id = 5, BookId = 1, PublishDate = "04/09/2015", Rating = 5, ReviewerName= "Ben Davis", ReviewText = "Excellent Book!" }
            };
        }

        public Review GetReviewByBookId(int id)
        {
            return _reviews.Find(x => x.BookId == id);
        }

        public List<Review> GetReviews()
        {
            return _reviews;
        }
    }
}