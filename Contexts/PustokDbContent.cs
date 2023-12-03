using Microsoft.EntityFrameworkCore;
using Pustok2.Models;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace Pustok2.Contexts
{
    public class PustokDbContent: DbContext
    {
        public DbSet<Slider> Sliders { get; set; }
        //Optionsu evvel override edirdik indi konstruktorda gondermek lazimdi
        public PustokDbContent(DbContextOptions opt):base(opt)
        {

        }

    }
}
