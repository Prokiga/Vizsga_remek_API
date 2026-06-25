using Microsoft.EntityFrameworkCore;

namespace WebAPI.Model
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {

        }

        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<users> users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("SERVER=localhost;DATABASE=szines_negy_evszak;Uid=root;PWD=");
        }
    }
}
