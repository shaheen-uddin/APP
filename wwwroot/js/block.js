$(document).ready(function(){
        
    let url = '/Trainee/Block';

    $('#CellNo').on('change',function(){
     let cell = $(this).val();
    // console.log(cell);
     if(cell !=null && cell.length == 11){
        // console.log(cell);

        getAysncData(url,cell,'#CellAlert');
       /* $.ajax(
           {
               url : '/Trainee/Block',
               method : 'POST',
               data   : {uKey:cell},
               datType: 'json',
               success : function(data){
                if(data !=null){
                    console.log(data);
                }
               }
           }
           ); */
       }
    });


    function getAysncData(url,data,selector){
        console.log(url);
        console.log(data);
        console.log(selector);
        $.ajax(
            {
                url : url,
                method : 'POST',
                data   : {uKey:data},
                datType: 'json',
                success : function(person){
                // if(res !=null){
                     console.log(selector);
                     console.log(person);
                    // $.map(res,function(person){ 
                        $(selector).text(person.name+', You have already registered. No need to reregister.');
                        $(":input").prop("disabled", true);
                        $(':input[type="submit"]').prop('disabled', true);
                    // });
                 //}
                }
            }
            );
    }

    $('#NID').on('change',function(){
        let nid = $(this).val();
        if(nid !=''){
            getAysncData(url,nid,'#NIDAlert');
        }
    })

    $('#IndexNo').on('change',function(){
        let index = $(this).val();
        if(index !=''){
            getAysncData(url,index,'#indexAlert');
        }
    })
});