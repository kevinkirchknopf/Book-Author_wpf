using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Author_wpf.Modells;

namespace Book_Author_wpf.Services;
internal interface IAuthorService
{

    public List<Author> GetAllAuthor();

    public bool SaveAuthor(Author Author);
    public Author GetAuthor(int id);

}
