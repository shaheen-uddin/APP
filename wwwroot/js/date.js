$('document').ready(function()
    {
       /*  let holidays = ["2019-02-21","2019-03-17","2019-03-26","2019-04-14","2019-04-21","2019-05-01","2019-06-02","2019-06-04","2019-06-05","2019-06-06","2019-08-11","2019-08-12","2019-08-13","2019-08-15","2019-09-10","2019-10-08","2019-11-10","2019-12-16","2019-12-25","2020-02-21","2020-03-17",
        "2020-03-26","2020-05-01","2020-08-15","2020-12-16","2020-12-25"] */
      

        /* 
        $('#Course_Name').on('change',function()
           {
               let value = $('#Course_Name').val();
               //alert(value);
               if(value =='1')
                {
                     $('#BatchNo').val('154');
                     $('#OpeningDate').val('2019-04-10');
                     $('#ClosingDate').val('2019-07-08');
                }
                else
                {
                   $('#BatchNo').val('');
                    $('#OpeningDate').val('');
                    $('#ClosingDate').val(''); 
                }
              
               console.log($('#OpeningDate').val('2019-04-10'));
               console.log($('#ClosingDate').val('2019-07-08'));
           }
        );

        $('#DateOfBirth').on('change',function()
            {
               console.log($('#DateOfBirth').val());
               console.log(typeof($('#DateOfBirth').val()));
            }
        );

        dateFormat : "dd/mm/yyyy",
                 changeMonth : true,
                 changeYear : true,
                 appendText : "dd-mm-yyy",
                 yearRange : "2019:2020",
                 firstDay   : 5

        */
       function showDatePicker(selector)
       {
            $(selector).datepicker(
                
                {
                    dateFormat : "yy/mm/dd",
                    changeMonth : true,
                    changeYear : true,
                    appendText : "",
                    yearRange : "2019:2020",
                    firstDay   : 6
                }
            );
        }

        showDatePicker('#OpeningDate');
        showDatePicker('#ClosingDate');
       // showDatePicker('#DateOfBirth');
       
           $('#DateOfBirth').datepicker
           (
               {
                 dateFormat : "yy/mm/dd",
                 changeMonth : true,
                 changeYear : true,
                 appendText : "",
                 yearRange : "1950:2019",
                 firstDay   : 6
                 
             }
           );  
    }
);