using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;
using CandyStore.Models;

namespace CandyStore.Controllers
{
    public class CandyController : Controller
    {
        // GET: localhost:xx/Candy
        public ActionResult Index()
        {
            return View();
        }

        // GET: localhost:xx/Candy/Order
        
        public ActionResult Order()
        {
            return View();
        }
        // POST: localhost:xx/Candy/Checkout
        //POST DATA:
        //OrderName={Ordername}
        //CandySize={CandySize}
        [HttpPost]
        public ActionResult Checkout(String OrderName, String CandySize)
        {
            //Create an order object

            Order CandyOrder = new Order();
            CandyOrder.OrderName = OrderName;
            CandyOrder.CandySize = CandySize;


            //We can receive the ordername and output to the server name 
            Debug.WriteLine("I received the name " + OrderName);
            //ViewData["OrderName"] = OrderName;
           // ViewData["CandySize"] = CandySize;

            //We have the candy size
            //small is 9.99
            //medium is 13.99
            //large is 15.99
            //create the order total given by the candy size

            decimal OrderTotal = 0;
            
            if(CandySize == "S")
            {
                OrderTotal = 9.99M;
            }
            else if(CandySize == "M")
            {
                OrderTotal = 13.99M;
            }
            else if(CandySize == "L")
            {
                OrderTotal = 15.99M;
            }

            //ViewData["OrderTotal"]= OrderTotal;
            CandyOrder.OrderTotal = OrderTotal;

            //CandyOrder object will be passed
            return View(CandyOrder);
        }

    }
}