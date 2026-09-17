// reading relational Datas

// Eager loading

// Explicit loading

// Lazy loading

using Loadings_Eager_Loading_Revise;
using Microsoft.EntityFrameworkCore;

using ApplicationContext db = new();

#region Add Data 

//List<Student> studentsProgramming = new List<Student>
//{
//    new Student { FirstName = "Əli", LastName = "Məmmədov", Age = 20 },
//    new Student { FirstName = "Aysel", LastName = "Əliyeva", Age = 22 },
//    new Student { FirstName = "Orxan", LastName = "Hüseynov", Age = 21 },
//    new Student { FirstName = "Nigar", LastName = "Qasımova", Age = 19 },
//    new Student { FirstName = "Murad", LastName = "Həsənov", Age = 23 },
//    new Student { FirstName = "Leyla", LastName = "Quliyeva", Age = 20 },
//    new Student { FirstName = "Tural", LastName = "Rzayev", Age = 24 },
//    new Student { FirstName = "Günel", LastName = "Abbasova", Age = 21 },
//    new Student { FirstName = "Elvin", LastName = "İsmayılov", Age = 22 },
//    new Student { FirstName = "Səbinə", LastName = "Abdullayeva", Age = 19 },
//    new Student { FirstName = "Samir", LastName = "Cəfərov", Age = 20 },
//    new Student { FirstName = "Fidan", LastName = "Rüstəmova", Age = 21 },
//    new Student { FirstName = "Ramin", LastName = "Qurbanov", Age = 23 },
//    new Student { FirstName = "Nərgiz", LastName = "Sadıqova", Age = 22 },
//    new Student { FirstName = "Vüsal", LastName = "Əliyev", Age = 20 },
//    new Student { FirstName = "Ayan", LastName = "Məmmədova", Age = 19 },
//    new Student { FirstName = "Kamran", LastName = "Həsənov", Age = 24 },
//    new Student { FirstName = "Ləman", LastName = "Hüseynova", Age = 21 },
//    new Student { FirstName = "Fərid", LastName = "Quliyev", Age = 22 },
//    new Student { FirstName = "Sevinc", LastName = "Əliyeva", Age = 20 },
//    new Student { FirstName = "Anar", LastName = "Rzayev", Age = 23 },
//    new Student { FirstName = "Nərmin", LastName = "İsmayılova", Age = 21 },
//    new Student { FirstName = "Rauf", LastName = "Abbasov", Age = 22 },
//    new Student { FirstName = "Aytac", LastName = "Məmmədova", Age = 19 },
//    new Student { FirstName = "Kənan", LastName = "Qurbanov", Age = 20 },
//    new Student { FirstName = "Jalə", LastName = "Hüseynova", Age = 21 },
//    new Student { FirstName = "Emil", LastName = "Həsənov", Age = 24 },
//    new Student { FirstName = "Vəfa", LastName = "Quliyeva", Age = 22 },
//    new Student { FirstName = "Nihad", LastName = "Rüstəmov", Age = 20 },
//    new Student { FirstName = "Zaur", LastName = "Əliyev", Age = 21 }
//};

//List<Student> studentsCyberSecurity = new List<Student>
//{
//    new Student { FirstName = "Cavidan", LastName = "Babayev", Age = 20 },
//    new Student { FirstName = "Nuranə", LastName = "Əliyeva", Age = 21 },
//    new Student { FirstName = "Rəşad", LastName = "Məmmədov", Age = 19 },
//    new Student { FirstName = "Səma", LastName = "Hüseynova", Age = 22 },
//    new Student { FirstName = "Vüqar", LastName = "Həsənov", Age = 23 },
//    new Student { FirstName = "Zəhra", LastName = "Quliyeva", Age = 18 },
//    new Student { FirstName = "İbrahim", LastName = "Rzayev", Age = 20 },
//    new Student { FirstName = "Zeynəb", LastName = "Abbasova", Age = 21 },
//    new Student { FirstName = "Rəhman", LastName = "İsmayılov", Age = 24 },
//    new Student { FirstName = "Fidan", LastName = "Abdullayeva", Age = 19 },
//    new Student { FirstName = "Tofiq", LastName = "Cəfərov", Age = 22 },
//    new Student { FirstName = "Gülnar", LastName = "Rüstəmova", Age = 20 },
//    new Student { FirstName = "Aslan", LastName = "Qurbanov", Age = 21 },
//    new Student { FirstName = "Türkan", LastName = "Sadıqova", Age = 23 },
//    new Student { FirstName = "Natiq", LastName = "Nəbiyev", Age = 20 },
//    new Student { FirstName = "Aytən", LastName = "Məmmədova", Age = 19 },
//    new Student { FirstName = "Rüstəm", LastName = "Həsənov", Age = 22 },
//    new Student { FirstName = "Mələk", LastName = "Hüseynova", Age = 18 },
//    new Student { FirstName = "Şahin", LastName = "Quliyev", Age = 24 },
//    new Student { FirstName = "Nəzrin", LastName = "Əliyeva", Age = 20 }
//};

//List<Student> studentsDesign = new List<Student>
//{
//    new Student { FirstName = "Orxan", LastName = "Əhmədov", Age = 21 },
//    new Student { FirstName = "Ləman", LastName = "Qasımova", Age = 20 },
//    new Student { FirstName = "Elşən", LastName = "Mikayılov", Age = 22 },
//    new Student { FirstName = "Sona", LastName = "Hacıyeva", Age = 19 },
//    new Student { FirstName = "Fərid", LastName = "Süleymanov", Age = 23 },
//    new Student { FirstName = "Şəbnəm", LastName = "Məhərrəmova", Age = 20 },
//    new Student { FirstName = "Nurlan", LastName = "Xəlilov", Age = 24 },
//    new Student { FirstName = "Gülşən", LastName = "Paşayeva", Age = 21 },
//    new Student { FirstName = "Pərviz", LastName = "Cəbrayılov", Age = 19 },
//    new Student { FirstName = "Vəfa", LastName = "Tağıyeva", Age = 22 },
//    new Student { FirstName = "Ceyhun", LastName = "Muradov", Age = 20 },
//    new Student { FirstName = "Əfsanə", LastName = "Bağırova", Age = 21 },
//    new Student { FirstName = "Rəfael", LastName = "Mahmudov", Age = 23 },
//    new Student { FirstName = "Samirə", LastName = "Ələkbərova", Age = 19 },
//    new Student { FirstName = "Teymur", LastName = "Şükürov", Age = 20 },
//    new Student { FirstName = "Rəna", LastName = "İbrahimova", Age = 22 },
//    new Student { FirstName = "Müşfiq", LastName = "Ağayev", Age = 24 },
//    new Student { FirstName = "Sevda", LastName = "Mehdiyeva", Age = 21 },
//    new Student { FirstName = "Kamran", LastName = "Həmzəyev", Age = 20 },
//    new Student { FirstName = "Aynur", LastName = "Fərəcova", Age = 19 },
//    new Student { FirstName = "Elnur", LastName = "Qarayev", Age = 22 },
//    new Student { FirstName = "Günay", LastName = "Rəhimova", Age = 20 },
//    new Student { FirstName = "Sadiq", LastName = "Bəşirov", Age = 21 },
//    new Student { FirstName = "Məryəm", LastName = "Nəsirova", Age = 19 },
//    new Student { FirstName = "Vüsal", LastName = "Kazımov", Age = 23 }
//};

//List<Group> groups = new List<Group>
//{
//    new Group { Name = "Programming", Students = studentsProgramming },
//    new Group { Name = "Cyber Security", Students = studentsCyberSecurity },
//    new Group { Name = "Design", Students = studentsDesign }
//};

//db.Groups.AddRange(groups);

//db.SaveChanges();

//var groups2 = db.Groups.ToList();

//foreach (var group in groups2)
//{
//    Console.WriteLine(group);

//    foreach (var student in group.Students)
//    {
//        Console.WriteLine($"  {student}");
//    }

//    Console.WriteLine();
//}


#endregion

#region Eager Loading, Include() 2 cedveli join edir, ThenInclude()

//var groups = db.Groups.Include(g => g.Students).ToList();
///*
// SELECT *
//FROM Groups AS G
//JOIN Students AS S ON G.Id = S.GroupId 
// */

//foreach (var group in groups)
//{
//    Console.WriteLine(group);

//    foreach (var student in group.Students)
//    {
//        Console.WriteLine($"  {student}");
//    }

//    Console.WriteLine();
//}


//var students = db.Students.Include(s=> s.Group).ToList();

//foreach (var student in students)
//{
//    Console.WriteLine($"{student} belongs to group {student.Group.Name}");

    

//    Console.WriteLine();
//}


#endregion