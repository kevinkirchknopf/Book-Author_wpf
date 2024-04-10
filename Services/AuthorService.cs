using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Author_wpf.Modells;

namespace Book_Author_wpf.Services;
public class AuthorService : IAuthorService
{
    B_A_Context _dbc;

    public AuthorService(B_A_Context dbc)
    {
        _dbc = dbc;
    }


    public List<Author> GetAllAuthor()
    {
        return _dbc.Author.ToList();
    }
    public Author GetAuthor(int id)
    {
        Author author = (from x in  _dbc.Author
                         where x.AuthorId == id
                         select x).FirstOrDefault();

        return author;
    }
    public bool SaveAuthor(Author Author)
    {
        _dbc.Add(Author);
        _dbc.SaveChanges();
        return true;
    }
}
