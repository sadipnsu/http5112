using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CandyStore.Models;

namespace CandyStore.Controllers
{
    public class CustomerController : Controller
    {
        // GET: localhost:xx/Customer/Show
        public ActionResult Show()
        {

            Customer newCustomer = new Customer();
            newCustomer.Id = 1;
            newCustomer.CustomerName = "Sadip";
            newCustomer.CustomerPhone = "xxx-134-2343";
            newCustomer.CustomerEmail = "sadip10@gmail.com";

            return View(newCustomer);
        }
    }
}