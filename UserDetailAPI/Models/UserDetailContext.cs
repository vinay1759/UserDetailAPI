using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace UserDetailAPI.Models
{
    public class UserDetailContext : DbContext
    {
        public UserDetailContext(DbContextOptions<UserDetailContext> options) 
            : base(options){ 

        }
        public DbSet<UserDetails> UserDetails { get; set; }
    }

    public class UserDetailContextFactory : IDesignTimeDbContextFactory<UserDetailContext>
    {
       public UserDetailContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<UserDetailContext>();
            optionsBuilder.UseSqlServer("Data Source=REALMEBOOK;Database=UserDetailsDB;Integrated Security=True");

            return new UserDetailContext(optionsBuilder.Options);
        }
    }
}
    
