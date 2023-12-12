using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Cumulative_2_N01627546.Models;
using System.Diagnostics;

namespace Cumulative_2_N01627546.Controllers
{
    public class TeacherController : Controller
    {
        // GET: Teacher
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// This Function returns the view and the List.cshtml file gets rendered
        /// For example: /Teacher/List
        /// Go to: /Views/Teacher/List.cshtml
        /// </summary>
        /// <returns>Sends the data model to the view and gets rendered</returns>


        //GET : /Teacher/List
        
        public ActionResult List(string SearchKey = null)
        {
            TeacherDataController controller = new TeacherDataController();
            IEnumerable<Teacher> Teachers = controller.ListTeachers(SearchKey);


            return View(Teachers);
        }

        /// <summary>
        /// This function returns the view and Show.cshtml files gets rendered
        /// For example: /Teacher/Show
        ///Route to /Views/Teacher/Show.cshtml
        /// </summary>
        /// <returns>Sends the data model to the view and the view gets rendered</returns>
             
        // GET : /Teacher/Show/{Id}
        public ActionResult Show(int id)
        {
            TeacherDataController controller = new TeacherDataController();
            Teacher SelectedTeacher = controller.FindTeacher(id);
            //  show an individual teacher given by the id
            return View(SelectedTeacher);
        }

        /// <summary>
        //GET : /Teacher/DeleteConfirm/{id}

        /// With this view, confirmation about the delete action occurs which they requested for
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult DeleteConfirm(int id)
        {
            TeacherDataController controller = new TeacherDataController();
            Teacher NewTeacher = controller.FindTeacher(id);


            return View(NewTeacher);
        }

        //POST : /Teacher/Delete/{id}
        /// <summary>
        ///  use this function to delete the teacher from the database and redirect to the list view
        /// </summary>
        /// <param name="id"></param>
        /// <returns>List view</returns>
        [HttpPost]
        public ActionResult Delete(int id)
        {
            TeacherDataController controller = new TeacherDataController();
            controller.DeleteTeacher(id);
            return RedirectToAction("List");
        }

        //GET : /Teacher/ValidationOfJs
        public ActionResult ValidationOfJs()
        {
            return View();
        }

        //GET : /Teacher/AddNew
        public ActionResult AddNew()
        {
            return View();
        }

        //POST : /Teacher/AddNew
        [HttpPost]
        public ActionResult AddNew(Teacher NewTeacher)
        {
            //  mentioned required fields in the model has values
            //  where Modelstate is used to validate them. This will either return true or false.
            if (ModelState.IsValid)
            {
                Teacher Teacher = new Teacher();
                Teacher.TeacherFName = NewTeacher.TeacherFName;
                Teacher.TeacherLName = NewTeacher.TeacherLName;
                Teacher.EmployeeNumber = NewTeacher.EmployeeNumber;
                Teacher.HireDate = Convert.ToDateTime(NewTeacher.HireDate);
                Teacher.Salary = Convert.ToDouble(NewTeacher.Salary);

                TeacherDataController controller = new TeacherDataController();
                controller.AddingTeacher(Teacher);

                return RedirectToAction("List");
            }
            return View(NewTeacher);
        }
    }


}