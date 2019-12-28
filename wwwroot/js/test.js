$(document).ready(function()
   {
    //$('#hide').hide();
 
    function showImgPrev(selector,error,prevImg,hide,err)
    {
        $(selector).on('change', function(evt)
        {
            let fileInput = $(selector);
            let filePath = $(selector).val();
            let allowedExts = /(\.jpg|\.jpeg|\.png|\.gif)$/i;
            if(!allowedExts.exec(filePath))
            {
                $(error).text('Please upload file having extension .jpeg/.jpg/.png/.gif only.');
                fileInput.val('');
                $(prevImg).attr('src','');
                $(hide).hide();
                return false;
            }
            else
            {
                $(error).text('');
                //alert('working');
                /* if(fileInput.files && fileInput.files[0])
                { */
                    let reader = new FileReader();
                    reader.onload = function()
                    {
                        $(prevImg).attr({src:reader.result,width:'170px',height:'170px'});
                        
                    }
                    $(err).text('');
                    
                    reader.readAsDataURL(evt.target.files[0])
                    $(hide).show();
               // } */
            }

        }
        );
    }
    showImgPrev('#ProfileImg','#error','#prevImg','#hide','#err',);
    showImgPrev('#sigImg','#error2','#prevSig','#hide2','#err2')

        
  $('.print').on('click',function(evt)
  {
    evt.preventDefault();
    window.print();
  });
   
 /*  $('#DateOfBirth').on('change',function()
  {
      console.log($('#DateOfBirth').val());
  }
  ); */

   }
);