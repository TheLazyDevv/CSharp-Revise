using Microsoft.EntityFrameworkCore;
using MigrationsRevise;

using StudentContext db = new StudentContext();

List<Student> students = new List<Student>
{
    new Student { FirstName = "Alice",LastName="ala", Email="alalal", Age = 20 },
    new Student { FirstName = "Bob", LastName="dd",Email="alalal" , Age = 22 },
    new Student { FirstName = "Charlie",LastName="ddad",Email="alalal" , Age = 21 }
};

db.Students.AddRange(students);
db.SaveChanges();