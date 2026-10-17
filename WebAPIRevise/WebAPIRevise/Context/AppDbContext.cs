using Microsoft.EntityFrameworkCore;
using WebAPIRevise.Entities;

namespace WebAPIRevise.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    public DbSet<User> Users { get; set; }
    public DbSet<Customer> Customers { get; set; }
}
