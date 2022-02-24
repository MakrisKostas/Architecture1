using Entities.OMADIKO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PersistanceGeneric.IRepositories
{
    public interface IDoctorRepository:IGenerricRepository<Doctor>
    {
        IEnumerable<Doctor> GetDoctorsOrderByYear();
        IEnumerable<Doctor> GetDoctorBiggestSalaryThan(Expression<Func<Doctor, bool>> predicate);
    }
}
