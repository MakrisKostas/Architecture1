using MyDataBase;
using PersistanceLayerNoGeneric.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Architecture1.Controllers
{
    public class StudentController : Controller
    {
        ApplicationDbContext db ;
        StudentRepository studentServise;

        public StudentController()
        {
            db = new ApplicationDbContext();
            studentServise = new StudentRepository(db);
        }
        // GET: Student
        public ActionResult Index()
        {
            var students = studentServise.GetAll();
            return View(students);
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