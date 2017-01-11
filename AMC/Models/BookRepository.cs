using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMC.Models
{
    public class BookRepository : IBookRepository
    {
        private List<Book> _books;

        public BookRepository()
        {
            _books = new List<Book>
            {
                new Book {Id = 1, Title= "Cross the Line", Description="Alex Cross chases a cold-blooded killer...with a conscience.", PublishDate = "11/21/2016", CoverImageUrl = "http://www.jamespatterson.com/images/books/lg-crossTheLine.jpg" },
                new Book {Id = 2, Title= "Fantastic Beasts and Where to Find Them", Description="Fantastic Beasts and Where to Find Them is an epic, adventure-packed screenplay with a gripping narrative and a huge cast of characters.", PublishDate = "03/01/2001", CoverImageUrl = "http://www.jkrowling.com/wp-content/uploads/2016/10/FB_Hero_OnGrey.png" },
                new Book {Id = 3, Title= "End of Watch", Description="End of Watch is a compelling and chilling suspense novel which sees retired detective Bill Hodges back on the trail of his nemesis Brady Hartsfield, the criminal the press called The Mercedes Killer", PublishDate = "06/07/2016", CoverImageUrl = "http://stephenking.com/promo/end-of-watch/novel/images/eow_full_cover.png" },
                new Book {Id = 4, Title= "The Night Bird", Description="Homicide detective Frost Easton doesn’t like coincidences. When a series of bizarre deaths rock San Francisco—as seemingly random women suffer violent psychotic breaks—Frost looks for a connection that leads him to psychiatrist Francesca Stein.", PublishDate = "02/01/2017", CoverImageUrl = "http://bfreemanbooks.com/wp-content/uploads/2016/10/THE-NIGHT-BIRD-Cover_website.jpg" },
                new Book {Id = 5, Title= "Night School", Description="A prequel set back in 1996 — Reacher is still in the army, age 35, and he’s moved to an emergency task force because the intelligence services in Europe have plucked a menacing phrase from the air: 'The American wants a hundred million dollars.' For what? ", PublishDate = "11/07/2016", CoverImageUrl = "http://www.leechild.com/images/books/night-school-hc.png" }
            };
        }
          

        public Book GetBook(int id)
        {
            return _books.Find(x => x.Id == id);
        }

        public IEnumerable<Book> GetBooks()
        {
            return _books;
        }




    }
}