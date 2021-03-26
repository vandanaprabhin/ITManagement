using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
 
namespace Sample2.Controllers
{
   public class SampleModel
    {
        public int Id { get; set; }
    }
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index(SampleModel sampleModel)
        {
            var test = sampleModel.Id;

            TempData["ID"] = test;
            ViewBag.Title= "Company";

            return View("Index");
            
        }

        public ActionResult Supplier(SampleModel sampleModel)
        {
            var test = sampleModel.Id;

            TempData["ID"] = test;
            ViewBag.Title = "Supplier";

            return View("Index");

        }

    }
}