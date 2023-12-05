using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SeasonApp.Models;

namespace SeasonApp.Controllers
{
    public class CourseAPIController : ApiController
    {

        [HttpGet]
        [Route("api/CourseAPI/GetCourse/{CourseCode}")]
        ///<summary>
        ///To Return the course name and course description given an input course code
        ///<param name="CourseCode"/>CourseCode</param>
        ///<returns>A string about the course name</returns>
        ///<example>
        /// GET api/CourseAPI/GetCourse/5101 -> Course Object
        /// </example>
        /// <example>
        /// GET api/CourseAPI/GetCourse/5102 -> Course Object
        /// </example>
        ///</summary>
        public Course GetCourse(int CourseCode)
        {

            string CourseName = "";
            string CourseDesc = "";

            //a specific course that want to return
            Course SelectedCourse = new Course();


            if (CourseCode == 5101)
            {
                CourseName = "Web Application Development";
                CourseDesc = "Learning how to build server rendered pages that connect to a database.";
            }
            else if (CourseCode == 5102)
            {
                CourseName = "Project Management";
                CourseDesc = "Learning to plan projects as well as work with a team.";
            }
            else if (CourseCode == 5103)
            {
                CourseName = "Web Programming";
                CourseDesc = "Learning JavaScript as it applies to Web Applications.";
            }
            else if (CourseCode == 5104)
            {
                CourseName = "Digital Design";
                CourseDesc = "Working with HTML and CSS as it applies to web applications";
            }
            else if (CourseCode == 5105)
            {
                CourseName = "Database Design";
                CourseDesc = "Working with Databases and MySQL as it applies to web applications";
            }

            SelectedCourse.CourseName = CourseName;
            SelectedCourse.CourseDesc = CourseDesc;
            SelectedCourse.CourseCode = CourseCode;

            return SelectedCourse;
        }

    }
}
