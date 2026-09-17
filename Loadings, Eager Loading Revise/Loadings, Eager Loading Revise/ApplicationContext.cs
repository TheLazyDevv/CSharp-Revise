using Microsoft.EntityFrameworkCore;

namespace Loadings_Eager_Loading_Revise;
class ApplicationContext : DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Group> Groups { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=EagerLoadingReviseDB;Integrated Security=True;Encrypt=False;Trust Server Certificate=False");
    }
}