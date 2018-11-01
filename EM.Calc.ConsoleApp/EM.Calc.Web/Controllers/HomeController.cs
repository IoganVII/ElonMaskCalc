using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EM.Calc.Core;

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

        public ActionResult Calc(string ope, string mas)
        {
            var realmas = mas
                .Split(' ')
                .Select(Convert.ToDouble)
                .ToArray();
            var calc = new Core.Calc();

            ViewBag.operartor = ope;

            switch (ope)
            {
                case "sum":
                    ViewBag.Message = calc.Execute(ope, realmas);
                    break;
                case "pow":
                    ViewBag.Message = calc.Execute(ope, realmas);
                    break;
                case "sub":
                    ViewBag.Message = calc.Execute(ope, realmas);
                    break;
                default:
                    break;

            }


            return View();
        }
    }
}