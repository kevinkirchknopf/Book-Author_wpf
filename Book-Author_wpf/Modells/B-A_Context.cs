using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Book_Author_wpf.Modells;
public class B_A_Context 
{


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //ConnectionString
        string c = "server = localhost; userid = root; password =; database = Filemek_WPF";

        //OptionBulider: ConnectionString + Szerver verzió (manuálisan, vagy Autodetect)
        optionsBuilder.UseMySql(c, ServerVersion.AutoDetect(c));


    }

}
