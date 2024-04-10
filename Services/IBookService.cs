using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Author_wpf.Modells;

namespace Book_Author_wpf.Services;
internal interface IBookService
{
    public List<Book> GetAllBook();

    public Book GetBook(int id);

    public bool SaveBook(Book book);






}
