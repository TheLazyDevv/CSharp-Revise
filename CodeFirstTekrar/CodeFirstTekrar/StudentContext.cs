using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstTekrar;

class StudentContext : DbContext
{
    public StudentContext() { 
        Database.EnsureCreated(); // kodu ise salanda baxir bele bir database varsa yaratmir yoxdusa yaradir
    }
    public DbSet<Student> Students { get; set; }
    public DbSet<StudentCard> StudentCards { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=localhost;Database=StudentsCodeFirst;Integrated Security=True;Encrypt=True;Trust Server Certificate=True;");
    }

}
