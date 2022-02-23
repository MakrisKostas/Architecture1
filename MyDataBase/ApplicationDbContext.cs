using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.School;
using Microsoft.AspNet.Identity.EntityFramework;
using Entities.IdentityUsers;
using MyDataBase.Initializers;
using Entities.Shcool;

namespace MyDataBase
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(): base("Sindesmos", throwIfV1Schema: false)
        {
            Database.SetInitializer<ApplicationDbContext>(new MockUpDbInitializer());
            Database.Initialize(false);
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Project> Projects { get; set; }

        public DbSet<Nurse> Nurses { get; set; }
    }
}
