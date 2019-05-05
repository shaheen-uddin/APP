using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.PixelFormats;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace AppProject.Services
{

    public class ImageProcess
    {
      //  private readonly IHostingEnvironment _env;

        public const string imgUploaddirOriginal ="uploads/original/";   
        public const string imgUploadDirResized ="uploads/resized/";
        public  const string imgUrlDb ="/uploads/resized/";
        public string imgUploaddirOriginalPath;
        public string imgUploadDirResizedPath;
        
        public ImageProcess()
        {}

        public void SetImgPath(IHostingEnvironment env,string filePath)
        {
          //  _env = env;
          //  imgUploaddirOriginalPath =
        //  CreatePath(env,filePath);
        imgUploaddirOriginalPath = Path.Combine(env.WebRootPath,imgUploaddirOriginal,filePath);
        imgUploadDirResizedPath = Path.Combine(env.WebRootPath,imgUploadDirResized,filePath);
            
        }
        public async Task SaveImg(IFormFile uploadImg)
        {
             using(var stream = new FileStream(imgUploaddirOriginalPath,FileMode.Create))
                     {
                           await uploadImg.CopyToAsync(stream);  
                     } 
        }
      
        public void PhotoResize()
        {
            using(Image<Rgba32> image = Image.Load(imgUploaddirOriginalPath))
                {
                    image.Mutate(x => x.Resize(170,170));
                    image.Save(imgUploadDirResizedPath);
                }
        }
     

        public string CreateImgName(IFormFile imgName,string name, int batchNo)
        {

             var img = imgName.FileName;
            // var sign = SignatureImg.FileName; 
            var imgExtension = Path.GetExtension(img);
            var nowImg = batchNo+"_"+name+"-"+DateTime.Now.ToString("yy-MM-dd-hh-mm-ss-ff")+imgExtension;
            // var signExtension = Path.GetExtension(sign);
            // var nowSign = batchNo+"_"+name+"-"+DateTime.Now.ToString("yy-MM-dd-hh-mm-ss-fff")+signExtension;
            return nowImg;
        }
         public string CreateSigName(IFormFile imgName,string name, int batchNo)
        {

             var img = imgName.FileName;
            // var sign = SignatureImg.FileName; 
            var imgExtension = Path.GetExtension(img);
           // var nowImg = batchNo+"_"+name+"-"+DateTime.Now.ToString("yy-MM-dd-hh-mm-ss-ff")+imgExtension;
            // var signExtension = Path.GetExtension(sign);
             var nowSign = batchNo+"_"+name+"-"+DateTime.Now.ToString("yy-MM-dd-hh-mm-ss-fff")+imgExtension;
            return nowSign;
        }

        
    }
}