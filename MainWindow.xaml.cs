using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Book_Author_wpf.Modells;
using Book_Author_wpf.Views;

namespace Book_Author_wpf;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    B_A_Context dbc;
    private AuthorListView authorListView;

    public MainWindow()
    {
        dbc = new B_A_Context();
        dbc.Database.EnsureCreated();

        dbc.SaveChanges();
        InitializeComponent();
        authorListView = new AuthorListView();
        ccAblak = authorListView;



      

    }
}