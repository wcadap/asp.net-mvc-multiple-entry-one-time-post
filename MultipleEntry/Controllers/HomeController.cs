using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultipleEntry.Models;

namespace MultipleEntry.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        [HttpPost]
        public ActionResult Index(string any = "")
        {
            IList<Client> _Client = new List<Client>();

            //Loop through the forms
            for (int i = 0; i <= Request.Form.Count; i++)
            {
                var ClientName = Request.Form["ClientName[" + i + "]"];
                var EMail = Request.Form["Email[" + i + "]"];

                if ((ClientName != null) && (EMail != null))
                {
                    _Client.Add(new Client { ClientName = ClientName, Email = EMail });
                }
            }

            //Once you got the records then you can do anything
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
