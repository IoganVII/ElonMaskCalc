using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EM.Calc.Core;
using EM.Calc.Web.Models;

namespace EM.Calc.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Execute(string ope, string mas)
        {
            var realmas = mas
                .Split(' ')
                .Select(Convert.ToDouble)
                .ToArray();
            var calc = new Core.Calc(@"D:\Temp");

            var result = calc.Execute(ope, realmas);

            var model = new OperationResult()
            {
                Name = ope,
                Result = result
            };

            return View(model);
        }
    }
}