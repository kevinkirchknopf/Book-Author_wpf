using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Book_Author_wpf.Modells;
public class B_A_Context : DbContext
{

    public DbSet<Author> Author
    {
    get; set; 
    }

    public DbSet<Book> Books
    {
    get; set; }

    public DbSet<Country> Country
    {
    get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //ConnectionString
        string c = "server = localhost; userid = root; password =; database = Book_Author_WPF";

        //OptionBulider: ConnectionString + Szerver verzió (manuálisan, vagy Autodetect)
        optionsBuilder.UseMySql(c, ServerVersion.AutoDetect(c));


    }

}
