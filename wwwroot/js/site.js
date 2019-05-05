// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
$('document').ready(function(){
 
   // $('.SL').text('ID NO.')
   $('#Course_Name').val('1');
  // $('#Course_Name').prop('readonly',true);
  //
   $('.BatchNo').val('155');
  // $('#BatchNo').prop('readonly',true);

   $('.OpeningDate').val('2019/04/29');
   //$('#OpeningDate').prop('disabled',true);
   $('.ClosingDate').val('2019/08/26');
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
 
  


});