using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sample2.Controllers
{


    public class InventoryModel
    {

        public string InvoiceNo { get; set; }
        public string Location { get; set; }
        public string RepackCaseNo { get; set; }
        public string PartNo { get; set; }
        public string Code { get; set; }
    }
    public class InventoryController : Controller
    {
        // GET: Inventory
        public ActionResult Index(InventoryModel inventoryModel)
        {

            TempData["Invoice"] = inventoryModel.InvoiceNo;
            TempData["Location"] = inventoryModel.Location;
            TempData["RepackCase"] = inventoryModel.RepackCaseNo;
            TempData["Part"] = inventoryModel.PartNo;
            TempData["Code"] = inventoryModel.Code;

            return View();
        }
    }
}