using Entities.School;
using Entities.Shcool;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataBase.Seeding
{
    public class SeedingService
    {
        ApplicationDbContext db;
        public SeedingService(ApplicationDbContext context)
        {
            db = context;
        }
        public void SeedStudent()
        {
            Student s1 = new Student() { Name = "Makris" ,Age=34};
            Student s2 = new Student() { Name = "Kostas", Age = 34 };
            Student s3 = new Student() { Name = "Aris", Age = 34 };
            Student s4 = new Student() { Name = "Maria", Age = 34 };
            Student s5 = new Student() { Name = "Konstantina", Age = 34 };
            Project p1 = new Project() { Title="C#"};
            Project p2 = new Project() { Title = "Java" };
            Project p3 = new Project() { Title = "Html" };
            p1.Student = s1;
            p2.Student = s2;
            p3.Student = s3;

            db.Projects.Add(p1);
            db.Projects.Add(p2);
            db.Projects.Add(p3);

            db.Students.Add(s1);
            db.Students.Add(s2);
            db.Students.Add(s3);
            db.Students.Add(s4);
            db.Students.Add(s5);
            db.SaveChanges();
        }
    }
}
