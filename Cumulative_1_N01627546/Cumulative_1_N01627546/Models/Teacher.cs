using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cumulative_1_N01627546.Models
{
    public class Teacher
    {
        // id of the teacher
        public int TeacherId { get; set; }
       
        // first name of the teacher
        public string TeacherFName { get; set; }

        // last name of the teacher
        public string TeacherLName { get; set; }

        //employee number of the teacher
        public string EmployeeNumber { get; set; }
        
        //hire date of the teacher
        public string HireDate { get; set; }

        //salary of the teacher
        public decimal Salary { get; set; }


    }
}