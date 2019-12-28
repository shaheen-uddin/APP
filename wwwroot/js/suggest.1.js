$(document).ready(function()
    {
    //    if( $('.searchType').val() =='homeDistrict')
    //    {
           $('#searchString').autocomplete(
                    {
                     if( $('.searchType').val() =='homeDistrict')
                   {
                       source : function(request, response) 


                       
                       /* {
                        $.ajax(
                            {
                              url :  "Util/SuggestDists",
                              dataType : "json",
                              data : { search : $('#searchString').val()},
                              success : function(data)
                              {
                                 response($.map(data, function(item){
                                    return {label:item.Name, value: item.Name};
                                 }));
                              },
                              error : function(xhr, status, error)
                              {
                                alert('Error');
                              }
                            }
                        );
                        } */
                    }
               );

       }
    }
);