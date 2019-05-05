$(document).ready(function()
    {
        
        //let cellNo = $('#CellNo').val();

        $('#CellNo').on('change', function()
            {
                let cellNo = $('#CellNo').val();
                if(cellNo.length == 11)
                {
                   // $('#alert').text(cellNo);
                    let data = $('#CellNo').val();
                    $.ajax(
                        {
                            url      : '/Trainee/Deny',
                            method   : 'POST',
                            data     : { cellNo : data},
                            dataType : 'text',
                            beforeSend: function (xhr) {
                                xhr.setRequestHeader("XSRF-TOKEN",
                                    $('input:hidden[name="__RequestVerificationToken"]').val());
                            },
                           
                            success  : function(msg)
                            {
                                let len = msg.length;
                                //let nMsg =msg+len;
                               // $('#alert').text(nMsg);
                                if(len > 0)
                                {
                                    $('#alert').text(msg);
                                    $(":input").prop("disabled", true);
                                    $(':input[type="submit"]').prop('disabled', true);
                                }

                                
                            }
                        }
                    ); 
                }
                
               // alert(cellNo);
              
            }
        );
        
    }
);