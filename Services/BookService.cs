using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Author_wpf.Modells;

namespace Book_Author_wpf.Services;


public class BookService : IBookService
{
    B_A_Context _dbc;
    public BookService( B_A_Context dbc)
    {
        _dbc = dbc;
    }


    public List<Book> GetAllBook()
    {
         return _dbc.Books.ToList();
    }

    public Book GetBook(int id)
    {
        Book selectedbook = (from x in _dbc.Books
                             where x.BookId == id
                             select x).FirstOrDefault();

        return selectedbook;
    }
    public bool SaveBook(Book book)
    {
        
        _dbc.Books.Add(book);

        _dbc.SaveChanges();

        return true;

    }
}
