using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Book_Author_wpf.Modells;
public class Book
{
    public int BookId
       {
        get;
        set;
        }

    public string Title
    {
        get;
        set;
    }

    public Author Author
    {
        get;
        set;
    }



}
