using Microsoft.EntityFrameworkCore;

class SchoolContext : DbContext
{
    public SchoolContext()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Faculty> Faculties { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=SchoolForFluentAPIRevise;Integrated Security=True;Trust Server Certificate=True;");

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //Group

        modelBuilder.Entity<Group>()
            .Property(x => x.GroupName)
            .IsRequired()
            .HasMaxLength(20);

        modelBuilder.Entity<Group>()
            .HasIndex(x => x.GroupName)
            .IsUnique();

        modelBuilder.Entity<Group>()
            .Property(x => x.Id)
            .ValueGeneratedOnAdd();

        modelBuilder.Entity<Group>()
            .ToTable(x=> x.HasCheckConstraint("CK_CourseYear",
            "CourseYear >= 1 AND CourseYear <= 4"));

        modelBuilder.Entity<Group>()
            .ToTable(x => x.HasCheckConstraint("CK_GroupRating",
           "GroupRating >= 0 AND GroupRating <= 12"));

        // Teacher

        modelBuilder.Entity<Teacher>()
            .Property(x => x.TeacherId)
            .HasColumnName("Id")
            .ValueGeneratedOnAdd();

        modelBuilder.Entity<Teacher>()
            .Property(x => x.FirstName)
            .IsRequired()
            .HasMaxLength(20);

        modelBuilder.Entity<Teacher>()
            .Property(x => x.LastName)
            .IsRequired()
            .HasMaxLength(20);

        modelBuilder.Entity<Teacher>()
            .Property(x => x.Email)
            .IsRequired()
            .HasColumnType("varchar(50)")
            .HasMaxLength(50);
          
        modelBuilder.Entity<Teacher>()
            .HasIndex(x => x.Email)
            .IsUnique();

        // Student

        modelBuilder.Entity<Student>()
            .HasOne(x => x.Group)
            .WithMany(x => x.Students)
            .HasForeignKey(x => x.GroupId)
            .OnDelete(DeleteBehavior.NoAction)
            .HasConstraintName("FK_Groups");

        modelBuilder.Entity<Student>()
            .Property(x => x.Id)
            .ValueGeneratedOnAdd();

        modelBuilder.Entity<Student>()
            .Property(x => x.FirstName)
            .IsRequired()
            .HasMaxLength(20);

        modelBuilder.Entity<Student>()
            .Property(x => x.LastName)
            .IsRequired()
            .HasMaxLength(20);

        modelBuilder.Entity<Student>()
            .Property(x => x.GroupId)
            .IsRequired()
            .HasColumnName("Id_Group");
    }
}