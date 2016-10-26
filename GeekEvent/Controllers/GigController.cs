using GeekEvent.Models;
using GeekEvent.ViewModel;
using Microsoft.AspNet.Identity;
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
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public ActionResult Create(GigFormViewModel gigForm)
        {
            if (!ModelState.IsValid)
            {
                /*
                 * To avoid [ArgumentNullException: Value cannot be null] 
                 * for Genre
                 */
                gigForm.Genres = _context.Genres.ToList();
                
                return View("Create", gigForm);
            }
            // to resolve INQ to Entities does not recognize 
            var artistId = User.Identity.GetUserId();
            // declared and replace 
            var artist = _context.Users.Single(u => u.Id == artistId);
            var genre =  _context.Genres.Single(g => g.Id == gigForm.Genre);
            var gig = new Gig
            {
                Artist = artist,
                DateTime = gigForm.GetDateTime(),

                Genre = genre,
                Venue = gigForm.Venue              

            };
            _context.Gigs.Add(gig);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}