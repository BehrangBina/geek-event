using GeekEvent.Models;
using GeekEvent.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GeekEvent.Controllers
{
    public class GigController : Controller
    {
        private ApplicationDbContext _context; 

        public GigController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Gig
        [Authorize]
        public ActionResult Create()
        {
            var viewModel = new GigFormViewModel
            {
                Genres = _context.Genres.ToList()
            };
            return View(viewModel);
        }
    }
}