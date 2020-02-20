using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleMVC.Controllers
{
    public class CashflowGeneratorController : Controller
    {
        // GET: CashflowGenerator
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public string Index()
        {
            return "This is my <b>default</b> aciton ";
        }

        public string Sample(string businessCenters)
        {
            return $"This fixed cashflow is made from {businessCenters}";
        }
    }
}