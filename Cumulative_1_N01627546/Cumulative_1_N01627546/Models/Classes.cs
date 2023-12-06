using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Cumulative_1_N01627546.Models
{
    public class Classes
    {
        // id of the course
        public int Id { get; set; }
       
        // name of the course
        public string ClassName { get; set; }
        
        // code of the course
        public string ClassCode { get; set; }
       
        // start date of the course
        public string StartDate { get; set; }
        
        // end date of the course
        public string EndDate { get; set; }
        
    }
}