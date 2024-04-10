using System.Configuration;
using System.Data;
using System.Windows;
using Book_Author_wpf.Modells;
using Book_Author_wpf.Services;
using Book_Author_wpf.ViewModells;
using Microsoft.Extensions.DependencyInjection;

namespace Book_Author_wpf;
/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    public App()
    {
        ///<summary>
        ///A PLUSZ SZOLGÁLTATÁSOK HOZZÁADÁS
        ///</summary>A
        Services = ConfigureServices();

        this.InitializeComponent();
    }


    //EZEN A METÓDUSON KERESZTÜL LEHET ELKÉRNI A VIEWMODEL-leket
    public new static App Current => (App)Application.Current;


    public IServiceProvider Services
    {
        get;
    }



    private static IServiceProvider ConfigureServices()
    {
        ///<summary>
        ///A SZOLGÁLTATÁSOK-KÉSZLET PÉLDÁNYOSÍTÁSA
        ///SAJÁT SZOLGÁTATÁS HOZZÁADÁSA
        ///A BŐVÍTETT KÉSZLET VISSZAADÁSA
        /// </summary>

        var services = new ServiceCollection();

        services.AddDbContext<B_A_Context>();

        //HA VALAMELYIK KONSTRUKTOR IDataService PÉLDÁNYT KÉR, AKKOR EGY DataService PÉLDÁNYT AD AZ "APP"
        services.AddSingleton<IBookService, BookService>();
        services.AddSingleton<IAuthorService, AuthorService>();
        services.AddTransient<AuthorListViewModell>();



        //HA VALAKI AZ APP-tól KÉR EGY UserViewModel PÉLDÁNYT AKKOR INNÉT AD EGYET!
  

        return services.BuildServiceProvider();
    }

}

