using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Hello
        public string Index()
        {
            return "This tooke me for <b>God Damn</b> forever to figure out what \"write a string to azure\" meant. I hope this is what you meant";
        }

        // GET: hello/Welcome
        // this code doesn't work.  I'm assuming it has something to do with this being the
        // home controller.  The routConfig.cs file shows that on this page anything after
        // a "/" is a controller.  but on the controller page anything after a "/" is a method...
        // so that's a little confusing.

        public string Welcome()
        {
            return "I still have no idea what any of this does.  Hopefully this will clear up soon.";
        }
    }
}
