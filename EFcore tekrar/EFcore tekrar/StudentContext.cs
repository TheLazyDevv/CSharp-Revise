
using Microsoft.EntityFrameworkCore;

namespace EFcore_tekrar;

class StudentContext: DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer(@"Server=localhost;Database=students;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

    }
}
