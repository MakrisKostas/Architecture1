using Entities.Shcool;
using MyDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;

namespace PersistanceLayerNoGeneric.Repositories
{
    public class ProjectRepository
    {
        protected readonly ApplicationDbContext Context;
        public ProjectRepository(ApplicationDbContext context)
        {
            Context = context;
        }

        public IEnumerable<Project> GetAll()
        {
            var projects = Context.Projects.Include(x => x.Student);
            return projects.ToList();
        }

        public Project Get(int id)
        {
            var project = Context.Projects.Find(id);
            return project;
        }

        public IEnumerable<Project> Find(Expression<Func<Project,bool>> predicate)
        {
            return Context.Projects.Where(predicate);
        }

        public Project SingeOrDefault(Expression<Func<Project, bool>> predicate)
        {
            return Context.Projects.SingleOrDefault(predicate);
        }



        public void Add(Project project)
        {
            Context.Projects.Add(project);
            Context.SaveChanges();
        }

        public void AddRange(IEnumerable<Project> project)
        {
            Context.Projects.AddRange(project);
            Context.SaveChanges();
        }

        public void Remove(Project project)
        {
            Context.Projects.Remove(project);
            Context.SaveChanges();
        }

        public void Remove(int id)
        {
            var project = Context.Projects.Find(id);
            if (project == null)
            {
                throw new ArgumentException("Project does not Exist");
            }
            Context.Projects.Remove(project);
            Context.SaveChanges();
        }

        public void RemoceChange(IEnumerable<Project> projects)
        {
            Context.Projects.RemoveRange(projects);
            Context.SaveChanges();
        }

        public void Edit(Project project)
        {
            var pro = Context.Students.Find(project.ProjectId);
            if (pro == null)
            {
                throw new ArgumentException("Project Does not Exist");
            }

            Context.Entry(pro).State = EntityState.Modified;
            Context.SaveChanges();
        }










    }
}
