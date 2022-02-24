using Entities.OMADIKO;
using MyDataBase;
using PersistanceGeneric.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Architecture1.Controllers.APIControllers
{
    public class DoctorController : ApiController
    {
        private ApplicationDbContext db;
        private DoctorRepository docotrService;

        public DoctorController()
        {
            db = new ApplicationDbContext();
            docotrService = new DoctorRepository(db);
        }

        public IHttpActionResult GetAll()
        {
            return Json(docotrService.GetAll());
        }
        public IHttpActionResult GetDoctorBiggestSalaryThan(double salary)
        {
            return Json(docotrService.GetDoctorBiggestSalaryThan(d=>d.Salary> salary));
        }

        






        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
