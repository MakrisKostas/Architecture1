using Entities.School;
using MyDataBase;
using PersistanceGeneric.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistanceGeneric.Repositories
{
    public class ProjectRepository : GenericRepository<Project>, IProjectRepository
    {
        
        public ProjectRepository(ApplicationDbContext context):base(context)
        {
        }
      

        public IEnumerable<Project> GetProjectOrderBy()
        {
            return Context.Projects.OrderBy(x=>x.Title).ToList();
        }
    }
}
