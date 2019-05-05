$(document).ready(function()
    {
        $('#imgToggle').hide();
        $('#signToggle').hide();
        
        $('#editPhoto').on('change',function(evt)
            {
                let fileInput = $('#editPhoto');
                let filePath = $('#editPhoto').val();
                let allowedExts = /(\.jpg|\.jpeg|\.png|\.gif)$/i;
                if(!allowedExts.exec(filePath))
                {
                    $('#editPhotoError').text('Please upload file having extension .jpeg/.jpg/.png/.gif only.');
                    fileInput.val('');
                   // $('#prevImg').attr('src','');
                  //  $('#hide').hide();
                    return false;
                }
                else
                {
                    $('#editPhotoError').text('');
                    
                        let reader = new FileReader();
                        reader.onload = function()
                        {
                            $('#prevPhoto').attr({src:''});
                            $('#prevPhoto').attr({src:reader.result,width:'350px',height:'200px'});
                            $('#imgToggle').prop('checked', true);
                            $('#imgToggle').show();
                            
                        }
                       // $('#err').text('');
                        
                        reader.readAsDataURL(evt.target.files[0]);
                       
                       // $('#hide').show();
                   // } */
                }
            }
        
        
        ); /*********end of editPhoto*****************/


        $('#editSign').on('change',function(evt)
        {
            let fileInput = $('#editSign');
            let filePath = $('#editSign').val();
            let allowedExts = /(\.jpg|\.jpeg|\.png|\.gif)$/i;
            if(!allowedExts.exec(filePath))
            {
                $('#editSignError').text('Please upload file having extension .jpeg/.jpg/.png/.gif only.');
                fileInput.val('');
               // $('#prevImg').attr('src','');
              //  $('#hide').hide();
                return false;
            }
            else
            {
                $('#editSignError').text('');
                
                    let reader = new FileReader();
                    reader.onload = function()
                    {
                        $('#prevSign').attr({src:''});
                        $('#prevSign').attr({src:reader.result,width:'350px',height:'200px'});
                        $('#signToggle').prop('checked', true);
                        $('#signToggle').show();
                        
                    }
                   // $('#err').text('');
                    
                    reader.readAsDataURL(evt.target.files[0])
                   // $('#hide').show();
               // } */
            }
        }
    
    
    ); //*******end of editSign */

       // alert($('#ProfileImagePath').val());
       // alert('#SignatureImgPath').val();
       
       $('#imgToggle').on('change', function()
         {
            if(!this.checked)
            {
                $('#prevPhoto').attr({src:$('#ProfileImagePath').val()});
                $('#editPhoto').val('');
            }
         });

         $('#signToggle').on('change', function()
         {
            if(!this.checked)
            {
                $('#prevSign').attr({src:$('#SignatureImgPath').val()});
                $('#editSign').val('');
            }
         });
       
     
    }
);