// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$('document').ready(function(){
 
   // $('.SL').text('ID NO.')
   $('#Course_Name').val('1');
  // $('#Course_Name').prop('readonly',true);
  //
   $('.BatchNo').val('157');
  // $('#BatchNo').prop('readonly',true);

   $('.OpeningDate').val('2020-01-07');
   //$('#OpeningDate').prop('disabled',true);
   $('.ClosingDate').val('2020-05-05');
   //$('#ClosingDate').prop('disabled',true);
   $('#LastNaemCourseAttendeded').prop('disabled',true); 


   /* if($('#Course_Name').is(':checked'))
   {
      ('#Course_Name').prop('disabled',true);
   } */

  
   $('#Course_Name').on('change',function()
      {
         if($('#Course_Name').val('1') !='1')
         {
            alert('Online Registration is currently close for the course you selected.');
            $(":input").prop("disabled", true);
         }

      }
   
   );
 
  $('#NameOfCadre').on('change',function(){
     console.log($(this).val());
     if($(this).val() =='1'){
        $('#BCSBatchNo').prop('disabled',true);
     }else{
      $('#BCSBatchNo').prop('disabled',false);
     }
  })
  // $('label').after('<i class="fas fa-asterisk"></i>');

});