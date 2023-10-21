using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AssignmentTwo.Controllers
{
    public class J3Controller : ApiController
    {
        [Route("api/J2/CalculateSumacSequenceLen/{t1}/{t2}")]
        [HttpGet]

        public int CalculateSumacSequenceLength(int t1, int t2)
        {
            int length = 2; // The sequence already has t1 and t2

            while (t1 >= t2)
            {
                int temp = t1;
                t1 = t2;
                t2 = temp - t1;
                length++;
            }

            return length;
        }

        //There is another function but I am still thinking about that. I couldn't solve this time. Hopefully will try again 
    }
}
