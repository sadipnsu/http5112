using Cumulative_1_N01627546.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Cumulative_1_N01627546.Controllers
{
    public class StudentDataController : ApiController
    {
        // The database context class which allows us to access our MySQL Database.
        private SchoolDbContext School = new SchoolDbContext();

        /// <summary>
        /// Returns a list of students
        /// </summary>
        /// <param name="searchKey">the term that the user want to serve</param>
        /// <example>GET api/StudentsList</example>
        /// <returns>
        /// A list of students objects.
        /// </returns>
        /// 
        [HttpGet]
        [Route("api/StudentsList/{searchKey?}")]
        public IEnumerable<Student> StudentsList(string searchKey)
        {
            // create an instance
            MySqlConnection Conn = School.AccessDatabase();

            // open the connection
            Conn.Open();

            // create a command
            MySqlCommand cmd = Conn.CreateCommand();

            // query
            cmd.CommandText = "Select * from students where lower(studentfname) like lower(@key) or lower(studentlname) like lower(@key) or lower(concat(studentfname, ' ', studentlname)) like lower(@key)";

            // parameterise the query
            cmd.Parameters.AddWithValue("@key", "%" + searchKey + "%");
            cmd.Prepare();

            // gather Result Set
            MySqlDataReader ResultSet = cmd.ExecuteReader();

            // create an empty list of students
            List<Student> students = new List<Student> { };

            // loop Through Each Result Set
            while (ResultSet.Read())
            {
                //Access Column information by the DB column name as an index
                int studentId = Convert.ToInt32(ResultSet["studentid"]);
                string studentFName = ResultSet["studentfname"].ToString();
                string studentLName = ResultSet["studentlname"].ToString();

                Student newStudent = new Student();
                newStudent.id = studentId;
                newStudent.firstName = studentFName;
                newStudent.lastName = studentLName;

                // add the new student to the List
                students.Add(newStudent);
            }

            // close the connection 
            Conn.Close();

            // return the final list of students
            return students;
        }


        /// <summary>
        /// Returns details of the student with a given id
        /// </summary>
        /// <param name="id">the id of the student to fetch details</param>
        /// <example>GET api/fetchStudentDetails/2</example>
        /// <returns>
        /// A Single student details
        /// </returns>
        [HttpGet]
        [Route("api/FindStudent/{id}")]
        public Student FindStudent(int id)
        {
            // create an instance
            MySqlConnection Conn = School.AccessDatabase();

            // open the connection
            Conn.Open();

            // create a command
            MySqlCommand cmd = Conn.CreateCommand();

            // query
            cmd.CommandText = "Select * from students where studentid = @id";

            // parameterise the query
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Prepare();

            //Gather Result Set of Query into a variable
            MySqlDataReader ResultSet = cmd.ExecuteReader();

            // create an empty student object
            Student student = new Student();

            //Loop Through Each Row the Result Set
            while (ResultSet.Read())
            {
                //Access Column information by the DB column name as an index
                int studentId = Convert.ToInt32(ResultSet["studentid"]);
                string studentFname = ResultSet["studentfname"].ToString();
                string studentLname = ResultSet["studentlname"].ToString();
                string studentNumber = ResultSet["studentnumber"].ToString();
                string studentEnrolDate = Convert.ToDateTime(ResultSet["enroldate"]).ToString("dd/MM/yyyy");

                student.id = studentId;
                student.firstName = studentFname;
                student.lastName = studentLname;
                student.studentNumber = studentNumber;
                student.enrolDate = studentEnrolDate;
            }

            // close the connection 
            Conn.Close();

            return student;
        }



    }
}
