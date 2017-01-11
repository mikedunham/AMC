using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMC.Models
{
    public class CategoryRepository : ICategoryRepository
    {

        private List<Category> _categories;

        public CategoryRepository()
        {
            _categories = new List<Category>
            {
                new Category {Id =1, BookId = 5, Name = "Fiction" },
                new Category {Id =2, BookId = 4, Name = "Science Fiction" },
                new Category {Id =3, BookId = 3, Name = "Thriller" },
                new Category {Id =4, BookId = 2, Name = "Western" },
                new Category {Id =5, BookId = 1, Name = "Crime" }
            };
        }

        public IEnumerable<Category> GetCategories()
        {
            return _categories;
        }

        public Category GetCategoryByBookId(int id)
        {
            return _categories.Find(x => x.BookId == id);
        }
    }
}