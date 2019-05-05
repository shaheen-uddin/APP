$(document).ready(function()
    {
        $('.searchType').on('change',function()
            {
               let searchType = $('.searchType').val(); 
               console.log(searchType.length);
               if(searchType == 'gender')
               {
                console.log(searchType);
                   $('#searchString').replaceWith('<select name="searchString" class="form-control-label src"  style="width:100%" id="searchString"><option value="">Select a gender</option><option value="male">Male</option><option value="female">Female</option></select>');
               }

              else if(searchType == 'dsheCategory')
               {
                console.log(searchType);
                   $('#searchString').replaceWith('<select name="searchString" class="form-control-label src"  style="width:100%" id="searchString"><option value="">Select a dshe category</option><option value="male">Male</option><option value="female">Female</option><option value="femaleWithChild"> Female with child</option><option value="maleWaiting">Male (waiting)</option><option value="femaleWaiting">Female (waiting)</option><option value="femaleWithChildWaiting">Female with child (waiting)</option></select>');
               }
               else 
               {
                $('#searchString').replaceWith('<input type="text" name="searchString" class="form-control-label"  style="width:100%" id="searchString"/>');
               }

            }
        );
      /*   $('#searchBtn').on('submit',function(evt)
        {
            alert('working');
            //evt.preventDefault();
            evt.preventDefault();
            let searchType = $('.searchType').val();
            console.log(searchType);

            console.log(searchType.length );
            if(searchType.length <=0)
            {
                $('#searchTypeAlert').show();
            }
            else
            {
                $('#searchTypeAlert').show();

            }

        }); */

       /*  $('#searchBtn').on('submit',function()
        {
            alert('working');
        }); */
        


    });