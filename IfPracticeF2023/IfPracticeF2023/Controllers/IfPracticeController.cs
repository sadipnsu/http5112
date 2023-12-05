using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IfPracticeF2023.Controllers
{
    public class IfPracticeController : ApiController
    {
        [Route("api/IfPractice/Hello")]
        [HttpGet]
        //GET api/IfPractice/Hello -> "Test Message"
        public String Hello()
        {
            return "Greetings";
        }

        //GET api/IfPractice/GoodBye -> "Test Message"
        public String GoodBye() 
        {
            return "Have a good day";    
        }
    }
}
