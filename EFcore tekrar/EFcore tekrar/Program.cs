// EF core

// Database first
// Code first
// Model first

#region AddData
using EFcore_tekrar;

//using (StudentContext db = new()) // using istifade elemekcun IDisposable olmalidi
//{
//    Student student1 = new()
//   {
//       FirstName = "Ibo",
//      LastName = "Mir",
//      Age = 1,
//      Group = "1A",
//      Gender = "Male"
//   };

//   db.Students.Add(student1);
//   db.SaveChanges();
//};

#endregion

#region ReadData

//using (var db = new StudentContext())
//{
//    var student = db.Students.FirstOrDefault(s => s.Id == 5); // default null qaytarir 
//    if (student != null) Console.WriteLine(student.FirstName);
//    else Console.WriteLine("student not found");
//}

#endregion

#region DeleteData
//using var db = new StudentContext();
//db.Remove(db.Students.First());
//db.SaveChanges();


#endregion

#region UpdateData

using var db = new StudentContext();

var student = db.Students.FirstOrDefault(x => x.Id == 5);

if (student != null) { student.FirstName = "Ibra"; db.Update(student); db.SaveChanges(); };



#endregion