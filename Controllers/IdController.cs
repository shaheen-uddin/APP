using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppProject.Models;
using AppProject.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace AppProject.Controllers
{
    public class IdController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly IHostingEnvironment _env;
         private readonly ImageProcess _imageProcess;

        public IdController(ApplicationContext context,ImageProcess imgProcess,IHostingEnvironment env)
        {
            _context = context;
            _imageProcess = imgProcess;
            _env = env;

        }

        public IActionResult Index()
        {
            return Content("Working");
        }
        [Authorize]
         public async Task<IActionResult> GenerateID(int? id )
        {
            if (id == null)
            {
                return NotFound();
            }

          
            var trainee = await _context.Trainees.FindAsync(id);
            if (trainee == null)
            {
                return NotFound();
            }
            //ViewBag.UID = trainee.Guid;
            return View(trainee);
        }
         [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> GenerateID(int id, [Bind("ID,DsheSL,TraineeType,Course_Name,BatchNo,OpeningDate,ClosingDate,LastNaemCourseAttendeded,Venue,Name,FatherName,MotherName,Gender,DateOfBirth,BloodGroup,MaritalStatus,Age,CellNo,Email,NID,PermanentAddress,Designation,IndexNo,NameOfCadre,BCSBatchNo,WorkplaceAddress,EiinNo,AcademicQualification,Subject,EmmergencyContactName,EmmergencyContactCellNo,ProfileImagePath,SignatureImgPath,RegDate,Guid,TraineeSerial")] Trainee trainee, IFormFile editPhoto, IFormFile editSign,string ProfileImagePath, string SignatureImgPath)
        {
            if (id != trainee.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
              int bn;
              var name = trainee.Name;
              name = name.Replace(" ","_");
              var batchNo = trainee.BatchNo;
            
                if(editPhoto !=null)

                {
                    if(editPhoto.Length > 0 )
                    {
                    
                    string dateImg =_imageProcess.CreateImgName(editPhoto,name,batchNo);
                    
                    _imageProcess.SetImgPath(_env,dateImg);
                    await _imageProcess.SaveImg(editPhoto);
                    _imageProcess.PhotoResize();
                    trainee.ProfileImagePath = ImageProcess.imgUrlDb+dateImg;
                
                    }
                }
                if(editSign !=null)
                    {

                    
                    if(editSign.Length > 0 )
                    {
                    
                            string dateSign= _imageProcess.CreateSigName(editSign,name,batchNo);
                            _imageProcess.SetImgPath(_env,dateSign);
                            await _imageProcess.SaveImg(editSign);
                            _imageProcess.PhotoResize();
                            trainee.SignatureImgPath = ImageProcess.imgUrlDb+dateSign;

                    }
                }
                try
                {
                    //trainee.RegDate = 
                    _context.Update(trainee);
                    await _context.SaveChangesAsync();
                     bn = trainee.BatchNo;
                     ViewBag.Batch = trainee.BatchNo;
                     ViewBag.Duration = trainee.OpeningDate.ToString("yyyyy/MM/dd")+" - " + trainee.ClosingDate.ToString("yyyy/MM/dd");
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TraineeExists(trainee.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                //return RedirectToAction("List","Trainee"); 
               // return Content("");
               return RedirectToAction("ShowIDPage", new {bn = bn}); 
            }
            return View(trainee);
           //return Content("");
        }
       // [Authorize]
        public async  Task<IActionResult> Record(int? bn)
        {
            var trainees = await _context.Trainees.Where(b => b.BatchNo ==bn).OrderBy(d =>d.TraineeSerial).ToListAsync();
            return View(trainees);
        }
        private bool TraineeExists(int id)
        {
            return _context.Trainees.Any(e => e.ID == id);
        }

        public async Task<IActionResult> ShowID(int? bn)
        {
            var trainees = await _context.Trainees.Where(b => b.BatchNo ==bn).OrderBy(d => d.TraineeSerial).ToListAsync();
            return View(trainees);
        }
         public async Task<IActionResult> ShowIDPage(int? bn)
         {
             var trainees =await _context.Trainees.Where(e => e.BatchNo ==bn)
                            .OrderBy(i => i.TraineeSerial).ToListAsync();

             return View(trainees);
         }

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
                             case "serial":

                                int serial ;
                                 bool found = Int32.TryParse(searchString,out serial);
                                if(!found)
                                {
                                    serial = 0;
                                } 
                                        var IdTrainees = await _context.Trainees.Where(x => x.BatchNo==bn && x.TraineeSerial == serial)
                                        .OrderBy(s => s.DsheSL).ToListAsync();
                                        if(IdTrainees.Count > 0)
                                            {
                        
                                                return View(IdTrainees);
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

       
        
    }
}
