using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMC.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetCategories();

        Category GetCategoryByBookId(int id);

    }
}