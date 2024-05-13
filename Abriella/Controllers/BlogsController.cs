using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Abriella.Controllers
{
    public class BlogsController : Controller
    {
        //
        // GET: /Blogs/

        public ActionResult blogswithoutrightsidebar()
        {
            return View();
        }

        public ActionResult blogsrightsidebar()
        {
            return View();
        }

        public ActionResult SingleBlog()
        {
            return View();
        }

    }
}