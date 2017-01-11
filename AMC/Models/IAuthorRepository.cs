using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMC.Models
{
    public interface IAuthorRepository
    {
        IEnumerable<Author> GetAuthors();

        Author GetAuthorByBookId(int id);
                
    }
}
