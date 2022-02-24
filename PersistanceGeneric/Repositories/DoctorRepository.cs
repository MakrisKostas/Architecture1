using Entities.OMADIKO;
using MyDataBase;
using PersistanceGeneric.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace PersistanceGeneric.Repositories
{
    public class DoctorRepository: GenericRepository<Doctor>,IDoctorRepository
    {
        public DoctorRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<Doctor> GetDoctorsOrderByYear()
        {
            return Context.Doctors.OrderBy(d => d.YearOfBirth);
        }


        public IEnumerable<Doctor> GetDoctorBiggestSalaryThan(Expression<Func<Doctor, bool>> predicate)
        {

            return Context.Doctors.Where(predicate);
        }
    }
}
