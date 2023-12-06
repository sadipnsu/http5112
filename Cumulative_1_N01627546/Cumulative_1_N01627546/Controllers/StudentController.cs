using Cumulative_1_N01627546.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cumulative_1_N01627546.Controllers
{
    public class StudentController : Controller
    {
        

        // GET: Student/List/{searchKey}
        public ActionResult List(string searchKey = "")
        {
            StudentDataController controller = new StudentDataController();
            IEnumerable<Student> Students = controller.StudentsList(searchKey);
            return View(Students);
        }


        //GET : Student/StudentInfo/{id}
        public ActionResult StudentInfo(int id)
        {
            StudentDataController controller = new StudentDataController();
            Student Student = controller.FindStudent(id);
            return View(Student);
        }

    }
}