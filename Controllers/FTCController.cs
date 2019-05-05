using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppProject.Models;
using Microsoft.AspNetCore.Authorization;

namespace AppProject.Controllers
{
    public class FTCController : Controller
    {
        private readonly ApplicationContext _context;

        public FTCController(ApplicationContext context)
        {
            _context = context;
        }

    
      /*   public async Task<IActionResult> List(int bn)
        {
            ViewBag.bn = bn;
            return View(await _context.Trainees.Where(x => x.BatchNo == bn).ToListAsync());
        } */
        [HttpGet]
        public async Task<IActionResult> List(int bn,string searchType=null, string searchString=null)
        {

            ViewBag.bn = bn;
          
           
            if(!string.IsNullOrEmpty(searchString))
            {
               
                       switch(searchType)
                       {
                           //***************** */
                            case "bcsBatch":

                                int batch ;
                                 bool success = Int32.TryParse(searchString,out batch);
                                if(!success)
                                {
                                    batch =0;
                                } 
                                        var bcsBatch = await _context.Trainees.Where(x => x.BatchNo==bn && x.BCSBatchNo == batch)
                                        .OrderBy(s => s.DsheSL).ToListAsync();
                                        if(bcsBatch.Count > 0)
                                            {
                        
                                                return View(bcsBatch);
                                            }
                                            else
                                            {
                                                ViewBag.SearchVal = searchString;

                                                return View();
                                            }
                                    
                                    
 
                           /************************** */
                           case "subject":
                                var trainees = await _context.Trainees.Where(x => x.BatchNo == bn && x.Subject.Contains(searchString.Trim()))
                                             .ToListAsync();
                                if(trainees.Count > 0)
                                {
                                    return View(trainees);
                                }
                                else
                                {
                                    //return RedirectToAction(nameof(HaveNoResult));
                                    ViewBag.SearchVal = searchString;
                                    return View();
                                }
                           // break;
                           case "name":
                                  var trainee = await _context.Trainees.Where(x => x.BatchNo == bn && x.Name.Contains(searchString.Trim()))
                                             .ToListAsync();
                                if(trainee.Count > 0)
                                {
                                    return View(trainee);
                                }
                                else
                                {
                                    //return RedirectToAction(nameof(HaveNoResult));
                                    ViewBag.SearchVal = searchString;
                                    return View();
                                }

                            case "gender":
                                if(searchString.Trim() == "female")
                                {
                                    var femaleTrainees = await _context.Trainees.Where(x => x.BatchNo ==bn && x.Gender.Equals(Sex.Female)).ToListAsync();
                                
                                     if(femaleTrainees.Count > 0)
                                        {
                    
                                            return View(femaleTrainees);
                                        }
                                        else
                                        {
                                            ViewBag.SearchVal = searchString;

                                            return View();
                                        }
                                }
                                 else if(searchString.Trim() == "male")
                                {
                                       {
                                    var maleTrainees = await _context.Trainees.Where(x => x.BatchNo ==bn && x.Gender.Equals(Sex.Male)).ToListAsync();
                                
                                     if(maleTrainees.Count > 0)
                                        {
                    
                                            return View(maleTrainees);
                                        }
                                        else
                                        {
                                            ViewBag.SearchVal = searchString;

                                            return View();
                                        }
                                }
                                
                          }

                           break;  
                           case "dsheCategory":
                                if(searchString.Trim() == "female")
                                    {
                                        var femaleTrainees = await _context.Trainees.Where(x => x.BatchNo ==bn && x.TraineeType.Equals(TraineeType.Female))
                                        .OrderBy(x =>x.DsheSL).ToListAsync();
                                    
                                        if(femaleTrainees.Count > 0)
                                            {
                        
                                                return View(femaleTrainees);
                                            }
                                            else
                                            {
                                                ViewBag.SearchVal = searchString;

                                                return View();
                                            }
                                    } 
                                    if(searchString.Trim() == "male")
                                    {
                                        var femaleTrainees = await _context.Trainees.Where(x => x.BatchNo ==bn && x.TraineeType.Equals(TraineeType.Male))
                                        .OrderBy(x =>x.DsheSL).ToListAsync();
                                    
                                        if(femaleTrainees.Count > 0)
                                            {
                        
                                                return View(femaleTrainees);
                                            }
                                            else
                                            {
                                                ViewBag.SearchVal = searchString;

                                                return View();
                                            }
                                    } 
                                    if(searchString.Trim() == "femaleWaiting")
                                    {
                                        var femaleTrainees = await _context.Trainees.Where(x => x.BatchNo ==bn && x.TraineeType.Equals(TraineeType.FemaleWaiting))
                                        .OrderBy(x =>x.DsheSL).ToListAsync();
                                    
                                        if(femaleTrainees.Count > 0)
                                            {
                        
                                                return View(femaleTrainees);
                                            }
                                            else
                                            {
                                                ViewBag.SearchVal = searchString;

                                                return View();
                                            }
                                    } 
                                    if(searchString.Trim() == "maleWaiting")
                                    {
                                        var femaleTrainees = await _context.Trainees.Where(x => x.BatchNo ==bn && x.TraineeType.Equals(TraineeType.MaleWaiting))
                                             .OrderBy(x =>x.DsheSL).ToListAsync();
                                    
                                        if(femaleTrainees.Count > 0)
                                            {
                        
                                                return View(femaleTrainees);
                                            }
                                            else
                                            {
                                                ViewBag.SearchVal = searchString;

                                                return View();
                                            }
                                    } 
                                    
                                    if(searchString.Trim() == "femaleWithChild")
                                    {
                                        var femaleTrainees = await _context.Trainees.Where(x => x.BatchNo ==bn && x.TraineeType.Equals(TraineeType.FemaleWithChild))
                                        .OrderBy(x =>x.DsheSL).ToListAsync();
                                    
                                        if(femaleTrainees.Count > 0)
                                            {
                        
                                                return View(femaleTrainees);
                                            }
                                            else
                                            {
                                                ViewBag.SearchVal = searchString;

                                                return View();
                                            }
                                    } 
                                    if(searchString.Trim() == "femaleWithChildWaiting")
                                    {
                                        var femaleTrainees = await _context.Trainees.Where(x => x.BatchNo ==bn && x.TraineeType.Equals(TraineeType.FemaleWithChildWaiting))
                                        .OrderBy(x =>x.DsheSL).ToListAsync();
                                    
                                        if(femaleTrainees.Count > 0)
                                            {
                        
                                                return View(femaleTrainees);
                                            }
                                            else
                                            {
                                                ViewBag.SearchVal = searchString;

                                                return View();
                                            }
                                    } 
                                break; 
                       }
                    
                 
            }
            return View(await _context.Trainees.Where(x => x.BatchNo == bn).ToListAsync());
           
        }

        // GET: FTC/Details/5
        public async Task<IActionResult> Details(int? id, int sl)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainee = await _context.Trainees
                .FirstOrDefaultAsync(m => m.ID == id);
            if (trainee == null)
            {
                return NotFound();
            }
            ViewBag.SL = sl+1;
            return View(trainee);
        }

   
       public IActionResult HaveNoResult()
       {
           return View();
       }
     
        

        private bool TraineeExists(int id)
        {
            return _context.Trainees.Any(e => e.ID == id);
        }
    }
}
