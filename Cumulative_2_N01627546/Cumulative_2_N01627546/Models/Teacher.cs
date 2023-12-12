using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Cumulative_2_N01627546.Models
{
    public class Teacher
    {

        // id of the teacher
        public int TeacherId { get; set; }

        // first name of the teacher
        [Required(ErrorMessage = "First Name is Required in this empty field !!")]
        public string TeacherFName { get; set; }

        // last name of the teacher
        [Required(ErrorMessage = "Last Name is Required this in this empty field !!")]
        public string TeacherLName { get; set; }

        //employee number of the teacher
        [Required(ErrorMessage = "Employee Number is Required in this empty field !!")]
        public string EmployeeNumber { get; set; }

        //hire date of the teacher
        [Required(ErrorMessage = "Hire Date is Required in this empty field !!")]
        [DataType(DataType.DateTime)]
        public DateTime HireDate { get; set; }

        //salary of the teacher
        [RegularExpression("^[0-9]*$")]
        [Required(ErrorMessage = "Salary is Required in this empty field!")]
        public double Salary { get; set; }
    }
}