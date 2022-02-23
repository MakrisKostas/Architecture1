using MyDataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PersistanceGeneric.Repositories
{
    public class GenericRepository<T> : IGenerricRepository<T> where T : class
    {
        protected readonly ApplicationDbContext Context;
        private DbSet<T> table = null;

        public GenericRepository(ApplicationDbContext context)
        {
            Context = context;
            table = Context.Set<T>();

        }

        public void Add(T entity)
        {
            table.Add(entity);
            Context.SaveChanges();
        }

        public T Get(int id)
        {
            return table.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public void Remove(int id)
        {
            var entity=table.Find(id);
            if (entity==null)
            {
                throw new ArgumentException("This Entity does not exist");
            }
            table.Remove(entity);
            Context.SaveChanges();
        }
    }
}
