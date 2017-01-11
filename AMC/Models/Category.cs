using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AMC.Models
{
    public class Category
    {
        public int Id { get; set; }

        public int BookId { get; set; }

        public string Name { get; set; }
    }
}