using Microsoft.EntityFrameworkCore;
using Pustok2.Models;
using Microsoft.EntityFrameworkCore.SqlServer;
using Pustok2.Models;

namespace Pustok2.Contexts
{
    public class PustokDbContent : DbContext
    {
        public PustokDbContent(DbContextOptions opt) : base(opt) { }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
