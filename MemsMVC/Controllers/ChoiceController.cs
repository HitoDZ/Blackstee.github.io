using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MemsMVC.Controllers
{
    public class ChoiceController : Controller
    {
        Random random = new Random();
        MemesContext _context;
        public ChoiceController(MemesContext context)
        {
            _context = context;
        }
        // GET: Choice
        public ActionResult Index()
        {
            var r1 = random.Next(1, 6);
            var r2 = random.Next(1, 6);
            do
            {
                r2 = random.Next(1, 6);
            } while (r1.Equals(r2));
            var item1 = _context.Memes.Where(item => item.Id == r1).FirstOrDefault();
            var item2 = _context.Memes.Where(item => item.Id == r2).FirstOrDefault();
            ViewBag.First = item1;
            ViewBag.Second = item2;
            return View();
        }
        public ActionResult Choice()
        {
            
            return View();
        }
    }
}