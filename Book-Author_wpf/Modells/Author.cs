using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book_Author_wpf.Modells;
public class Author
{
    public int AuthorId   {get; set;}
    public string FirstName   {get; set;}
    public string LastName {get; set;}

    public ICollection<Book> Books{get; set;}

    public Country Country {get; set;}

}
