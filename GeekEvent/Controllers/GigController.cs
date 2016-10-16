using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeekEvent.Controllers
{
    public class GigController : Controller
    {
        // GET: Gig
        public ActionResult Create()
        {
            return View();
        }
    }
}