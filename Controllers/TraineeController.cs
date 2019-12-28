using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AppProject.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.PixelFormats;
using AppProject.Services;
using X.PagedList;


namespace AppProject.Controllers
{
    public class TraineeController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly IHostingEnvironment _env;
        private readonly ImageProcess _imageProcess;

        public TraineeController(ApplicationContext context, IHostingEnvironment env,ImageProcess resize)
        {
            _context = context;
            _env = env;
            _imageProcess = resize;
        }

        // GET: Trainee
        public async Task<IActionResult> Index(int? page)
        {
            
            var pageNumber = page ?? 1;
            ViewBag.trainees = await _context.Trainees.ToList().ToPagedListAsync(pageNumber,5);
            

          //  return View(await _context.Trainees.ToListAsync());
           return View();
        }

        // GET: Trainee/Details/5
        public async Task<IActionResult> Details(int? id, int? sl)
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

            ViewBag.SL =sl+1;
            return View(trainee);
        }

        // GET: Trainee/Create
        public IActionResult Create()
        {
            var dists = _context.Districts.ToList();
            ViewBag.Dists = dists;
            return View();
        }

        // POST: Trainee/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,DsheSL,TraineeType,Course_Name,BatchNo,OpeningDate,ClosingDate,LastNaemCourseAttendeded,Name,FatherName,MotherName,Gender,DateOfBirth,BloodGroup,MaritalStatus,Age,CellNo,Email,NID,PermanentAddress,Designation,IndexNo,NameOfCadre,BCSBatchNo,WorkplaceAddress,EiinNo,AcademicQualification,Subject,EmmergencyContactName,EmmergencyContactCellNo,ProfileImagePath,SignatureImgPath,RegDate,Guid,HomeDistrict")] Trainee trainee,IFormFile ProfileImg,IFormFile SignatureImg)
       {
            if (ModelState.IsValid)
            {
                        var name = trainee.Name;
                        name = name.Replace(" ","_");
                        var batchNo = trainee.BatchNo;
                if(ProfileImg != null && ProfileImg.Length > 0 && SignatureImg != null && SignatureImg.Length >0)
                {       
                   string dateImg =_imageProcess.CreateImgName(ProfileImg,name,batchNo);
                   string dateSign= _imageProcess.CreateSigName(SignatureImg,name,batchNo);
 
                  _imageProcess.SetImgPath(_env,dateImg);
                  await _imageProcess.SaveImg(ProfileImg);
                  _imageProcess.PhotoResize();

                 _imageProcess.SetImgPath(_env,dateSign);
                  await _imageProcess.SaveImg(SignatureImg);
                  _imageProcess.PhotoResize();                      
                     
                    trainee.ProfileImagePath = ImageProcess.imgUrlDb+dateImg;
                    trainee.SignatureImgPath = ImageProcess.imgUrlDb+dateSign;
                    
                    trainee.RegDate = DateTime.Now;
                    trainee.Guid = System.Guid.NewGuid().ToString();
                    _context.Add(trainee);
                    await _context.SaveChangesAsync();
                    int id = trainee.ID;
                        
                       
                   // return RedirectToAction(nameof(Index));
                  // return RedirectToActiosn(nameof(Success));
                  return RedirectToAction("Success", new { id = id});
                } 
               /*  _context.Add(trainee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index)); */
               // return Content($"{ProfileImg.Length},and {SignatureImg.ContentType}");
            }
            return View(trainee);
            //return Content("AB ");
        }

        public async Task<IActionResult> Edit(int? id )
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
            var dists = _context.Districts.ToList();
            ViewBag.dists = dists;
            return View(trainee);
        }

        // POST: Trainee/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,DsheSL,TraineeType,Course_Name,BatchNo,OpeningDate,ClosingDate,LastNaemCourseAttendeded,Venue,Name,FatherName,MotherName,Gender,DateOfBirth,BloodGroup,MaritalStatus,Age,CellNo,Email,NID,PermanentAddress,Designation,IndexNo,NameOfCadre,BCSBatchNo,WorkplaceAddress,EiinNo,AcademicQualification,Subject,EmmergencyContactName,EmmergencyContactCellNo,ProfileImagePath,SignatureImgPath,RegDate,Guid,TraineeSerial,HomeDistrict")] Trainee trainee, IFormFile editPhoto, IFormFile editSign,string ProfileImagePath, string SignatureImgPath)
        {
            if (id != trainee.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
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
                return RedirectToAction(nameof(List)); 
               // return Content("");
            }
            return View(trainee);
           //return Content("");
        }

        // GET: Trainee/Delete/5
        public async Task<IActionResult> Delete(int? id)
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

            return View(trainee);
        }

        // POST: Trainee/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trainee = await _context.Trainees.FindAsync(id);
            _context.Trainees.Remove(trainee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(List));
        }

        private bool TraineeExists(int id)
        {
            return _context.Trainees.Any(e => e.ID == id);
        }
         public IActionResult Success(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainee = _context.Trainees
                .FirstOrDefault(m => m.ID == id);
            if (trainee == null)
            {
                return NotFound();
            }

            return View(trainee);
        }
        

        public async Task<IActionResult> Registered()
        {
            return View(await _context.Trainees.ToListAsync());
        }

        public async Task<IActionResult> List()
        {
            return View( await _context.Trainees.ToListAsync());
        }
        [HttpPost]
        public string Deny( string cellNo)
        {
            //return "It's working "+cellNo;
            if (cellNo == null)
            {
                return "";
            }

            var trainee =  _context.Trainees.Where( t => t.CellNo == cellNo)
                            .Select( t => new { t.Name, t.CellNo});
            if (trainee == null)
            {
                return "";
            }
            int c = trainee.Count();
            if(c > 0)
            foreach( var t in trainee)
            {
                return ($"{t.Name},You have already registered. No need to reregister.");
            }
           
            return "";
            
        }

        public JsonResult Block(string ukey)
        {
            if(!string.IsNullOrEmpty(ukey))
            {
                var person = _context.Trainees.FirstOrDefault(c => c.CellNo == ukey || c.NID ==ukey || c.IndexNo ==ukey);
                if(person !=null)
                {
                    return Json(person);
                  // return person.Name;

                }
                
            }
            return Json(null);
           // return "Problem";
        }
        
        
       
    }
}
