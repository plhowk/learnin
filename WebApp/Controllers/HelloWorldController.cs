﻿using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class Hello : Controller
    {
        // GET: Hello
        public string Index()
        {
            // TODO: retrieve this from the DB
            return "This is my <b>Default</b> action";
        }

        // GET: hello/Welcome

        public string Welcome()
        {
            return "this is the Welcome action method";
        }
    }
}

