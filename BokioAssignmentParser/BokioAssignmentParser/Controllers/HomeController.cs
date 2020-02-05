using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BokioAssignmentParser.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            //Implement I would suggest saving to a csv or json file and just write it to the bin directory. If you are more comfortable with another data store you are free to go for that. 
            return View();
        }
    }
}