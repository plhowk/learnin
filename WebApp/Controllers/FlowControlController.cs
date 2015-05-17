using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class FlowControlController : Controller
    {
        // GET: FlowControl
        public ActionResult Index()
        {
            List<int> count = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // TODO: ForEach loop
            // TODO: For loop
            // TODO: While loop
            // TODO: Do While loop (difference between this and while loop?)
            // https://msdn.microsoft.com/en-us/library/32dbftby.aspx

            // BONUS: Implementing loops with LINQ
            // BONUS: Decompile LINQ to see how it works

            // TODO: Conditional statements (if/else/switch)
            // https://msdn.microsoft.com/en-us/library/676s4xab.aspx

            // TODO: Understand operators
            // https://msdn.microsoft.com/en-us/library/6a71f45d.aspx

            return View();
        }
    }
}