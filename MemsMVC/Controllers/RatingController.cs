using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MemsMVC.Controllers
{
    public class RatingController : Controller
    {
        readonly MemesContext _context;
        public RatingController(MemesContext context)
        {
            _context = context;
        }
        // GET: Rating
        public ActionResult Index()
        {
            var data = _context.Memes.OrderByDescending(opt => opt.Result).ToList();
            return View(data);
        }
    }
}