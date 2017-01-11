using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMC.Models
{
    public interface IReviewRepository
    {
        List<Review> GetReviews();

        Review GetReviewByBookId(int id);
                
    }
}
