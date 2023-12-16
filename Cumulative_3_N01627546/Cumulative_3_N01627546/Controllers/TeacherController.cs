using Cumulative_3_N01627546.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cumulative_3_N01627546.Controllers
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

        /// <summary>
        /// Routes to the "Teacher Update" Page.
        /// </summary>
        /// 
        /// <param name="id">Teacher id</param>
        /// 
        /// <returns>"Update Teacher" webpage which provides the current information of the teacher and asks the user for new information as part of a form.</returns>
        /// 
        /// <example>GET : /Teacher/Update/2</example>
        public ActionResult Update(int id)
        {
            TeacherDataController controller = new TeacherDataController();
            Teacher SelectedTeacher = controller.FindTeacher(id);

            return View(SelectedTeacher);
        }


        /// <summary>
        /// Receives a POST request containing information about an existing Teacher in the system, with new values. Conveys this information to the API, and redirects to the "Teacher Show" page of our updated Teacher.
        /// </summary>
        /// <param name="id">Id of the Teacher to update</param>
        /// <param name="TeacherFname">The updated first name of the Teacher</param>
        /// <param name="TeacherLname">The updated last name of the Teacher</param>
        /// <param name="EmployeeNumber">The updated employee number of the Teacher.</param>
        /// <param name="HireDate">The updated hire date of the Teacher.</param>
        /// <param name="Salary">The updated salary of the Teacher.</param>
        /// <returns>A dynamic webpage which provides the current information of the Teacher.</returns>
        /// <example>
        /// POST : /Teacher/Update/5
        /// FORM DATA / POST DATA / REQUEST BODY 
        /// {
        ///	"TeacherFname":"Adam",
        ///	"TeacherLname":"Thomas",
        ///	"EmployeeNumber":"N028847",
        ///	"HireDate":"1/1/2022",
        ///	"Salary":"10000"
        /// }
        /// </example>
        [HttpPost]
        public ActionResult Update(int id, string TeacherFname, string TeacherLname, string EmployeeNumber,string HireDate, double Salary)
        {
            Teacher TeachrInfo = new Teacher();
            TeachrInfo.TeacherFName = TeacherFname;
            TeachrInfo.TeacherLName = TeacherLname;
            TeachrInfo.EmployeeNumber = EmployeeNumber;
            TeachrInfo.HireDate = Convert.ToDateTime(HireDate);
            TeachrInfo.Salary = Salary;

            TeacherDataController controller = new TeacherDataController();
            controller.UpdateTeacher(id, TeachrInfo);

            return RedirectToAction("Show/" + id);
        }


    }
}