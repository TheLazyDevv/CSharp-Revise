using CodeFirstTekrar;
using Microsoft.EntityFrameworkCore;

using StudentContext db = new();

//Student student = new Student()
//{
//    FirstName = "Sal",
//    LastName = "ma",
//    Birthday = new DateTime(2005, 5, 5)
//};


//StudentCard studentCard = new StudentCard()
//{
//    EndDate = new DateTime(2030, 6, 5),
//    Student = student
//};

//db.Students.Add(student);
//db.StudentCards.Add(studentCard);
//db.SaveChanges();

var studentCard = db.StudentCards.Include(sc => sc.Student).First();
Console.WriteLine(studentCard);
Console.WriteLine(studentCard.Student);