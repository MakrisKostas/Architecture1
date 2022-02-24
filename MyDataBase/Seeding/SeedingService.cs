using Entities.School;
using Entities.Shcool;
using Entities.OMADIKO;
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

            Patient t1 = new Patient() { Name = "Spiros", Arwstia = "Ilara" };
            Patient t2 = new Patient() { Name = "Kostas", Arwstia = "COVID" };
            Patient t3 = new Patient() { Name = "Maria", Arwstia = "Amigdales" };

            Doctor d1 = new Doctor() { Name = "Makis", YearOfBirth = 1992 };
            Doctor d2 = new Doctor() { Name = "Lazaros", YearOfBirth = 1983 };
            Doctor d3 = new Doctor() { Name = "Kuriakos", YearOfBirth = 1966 };

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

            db.Patient.Add(t1);
            db.Patient.Add(t2);
            db.Patient.Add(t3);

            db.Doctors.Add(d1);
            db.Doctors.Add(d2);
            db.Doctors.Add(d3);



            db.SaveChanges();


            Nurse n1 = new Nurse() { Name="Maria",Salary=1000};
            Nurse n2 = new Nurse() { Name="Sarakova",Salary=2000};
            Nurse n3 = new Nurse() { Name="Dimitris",Salary=3000};
            Nurse n4 = new Nurse() { Name="Koulis",Salary=4000};
            Nurse n5 = new Nurse() { Name="Soula",Salary=5000};
            Nurse n6 = new Nurse() { Name="Antouaneta",Salary=6000};
            Nurse n7 = new Nurse() { Name="Elisabeth",Salary=7000};
            Nurse n8 = new Nurse() { Name="Chris",Salary=8000};
            Nurse n9 = new Nurse() { Name="Mitsos",Salary=9000};
            Nurse n10 = new Nurse() { Name="Loukas",Salary=10000};
            

        }
    }
}
