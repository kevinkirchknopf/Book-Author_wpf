using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book_Author_wpf.Modells;
using Book_Author_wpf.Services;

namespace Book_Author_wpf.ViewModells;
internal class AuthorListViewModell
{

    private readonly IAuthorService _authorService;

    public ObservableCollection<Author> AuthorList
    {
    get; set; }

    public AuthorListViewModell(IAuthorService authorService)
    {
        _authorService = authorService;
        AuthorList = new ObservableCollection<Author>(_authorService.GetAllAuthor());
    }


}
