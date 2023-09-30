using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment1.Controllers
{
    public class NumberMachineController : ApiController
    {
        public String[] Get(int id)
        {
            var add = id + 5;
            var sub = id - 5;
            var multiply = id * 10;
            var div = id / 2;

            return new String[] { add.ToString() , sub.ToString() , multiply.ToString(), div.ToString() };
        }
    }
}
