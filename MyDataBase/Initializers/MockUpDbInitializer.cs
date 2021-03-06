using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MyDataBase.Seeding;

namespace MyDataBase.Initializers
{
    public class MockUpDbInitializer:DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            SeedingService service = new SeedingService(context);
            service.SeedStudent();

            base.Seed(context); 
        }
    }
}
