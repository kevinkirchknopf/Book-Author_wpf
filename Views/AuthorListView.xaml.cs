using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Book_Author_wpf.ViewModells;
using Microsoft.Extensions.DependencyInjection;

namespace Book_Author_wpf.Views;
/// <summary>
/// Interaction logic for AuthorListView.xaml
/// </summary>
public partial class AuthorListView : UserControl
{
    private readonly AuthorListViewModell als;
    public AuthorListView()
    {
        InitializeComponent();
        als = App.Current.Services.GetService<AuthorListViewModell>();
        this.DataContext = als.AuthorList;
    }
}
