using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistanceLayerNoGeneric.Repositories;
using PersistanceGeneric.Repositories;
using MyDataBase;
using Entities.School;
using ProjectRepository = PersistanceGeneric.Repositories.ProjectRepository;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            ProjectRepository projectServise = new ProjectRepository(context);

            var projects=projectServise.GetProjectOrderBy();
            foreach (var project in projects)
            {
                Console.WriteLine(project.Title);
            }
        }
    }
}