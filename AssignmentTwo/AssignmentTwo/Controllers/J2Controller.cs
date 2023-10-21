using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AssignmentTwo.Controllers
{
    public class J2Controller : ApiController
    {
        [Route("api/J2/DiceGame/{m}/{n}")]
        [HttpGet]
        //Created this function in order to execute the process
        public string DiceGame(int m, int n)
        {
            //Defining the sum of the total ways
            int waysToGetSum = 0;

            for (int firstDie = 1; firstDie <= m; firstDie++)
            {
                for (int secondDie = 1; secondDie <= n; secondDie++)
                {
                    if (firstDie + secondDie == 10)
                    {
                        waysToGetSum++;
                    }
                }
            }

            return "There are " +waysToGetSum +" total ways to get the sum 10"; // The final retrun value 
        }

    }
}
