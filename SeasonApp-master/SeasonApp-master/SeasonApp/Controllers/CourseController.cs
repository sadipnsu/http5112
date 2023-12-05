using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
using SeasonApp.Models;

namespace SeasonApp.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course/Index
        public ActionResult Index()
        {
            return View();
        }

        // GET: Course/Show?CourseCode
        public ActionResult Show(int CourseCode)
        {
            //objective: receive the course code from the form and render a new page with the relevant course information

            Debug.WriteLine("The course code information that I've pulled is "+CourseCode);

            //Instantiating the CourseAPI Controller
            CourseAPIController controller = new CourseAPIController();

            //Access the logic from our CourseAPI controller
            Course CourseInfo = controller.GetCourse(CourseCode);

            //Course Name
            Debug.WriteLine(CourseInfo.CourseName);
            Debug.WriteLine(CourseInfo.CourseDesc);
          

            //ViewData["CourseName"] = CourseInfo.CourseName;
            //ViewData["CourseDesc"] = CourseInfo.CourseDesc;
            //ViewData["CourseCode"] = CourseCode;

            return View(CourseInfo);
        }
    }
}