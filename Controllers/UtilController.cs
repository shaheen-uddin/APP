using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AppProject.Models;

namespace AppProject.Controllers
{
    public class UtilController : Controller
    {
         private readonly ApplicationContext _context;

         public UtilController(ApplicationContext context)
         {
             _context = context;
         }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult SuggestDists(string search)
        {
           var dists = _context.Districts.Where(x => x.Name.StartsWith(search)).Select(x => new District{ID = x.ID,Name=x.Name}).ToList();
           
            return  Json(dists);
        } 
    }
}