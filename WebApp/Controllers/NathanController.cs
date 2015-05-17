using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class NathanController : Controller
    {
        // GET: Nahtan
        public ActionResult Index()
        {
            // ViewBag is of type dynamic
            // https://msdn.microsoft.com/en-us/library/dd264736.aspx
            // TODO: Understand what dynamic is.
            // TODO: Understand strongly typed languages vs loosely typed languages
            // TODO: Understand runtime vs compile time.
            // BONUS: Decompile code to see how it works.
            ViewBag.NathanProp = "This is adding something to the viewbag.";
            ViewBag.IntProp = 1;
            return View();
        }
    }
}