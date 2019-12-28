$(document).ready(function(){
   
    $(':input').on('change',function(){
        let val = $(this).val()
        $(this).val(capitalize_Words(val));
        console.log(capitalize_Words(val));
        let val2 = $(this).val()
        $(this).val(upper(val2))
    });

    $('.age').on('click',function(){
       let dob = $('.dob').val();
       let odt = $('.odt').val();
       let age = $('.age');
       console.log('dob :'+dob+' , odt :'+odt+', age :'+age);
       calculateAge(dob,odt, age);
    })

});

function capitalize_Words(str)
{
return str.replace(/\w\S*/g, function(txt){return txt.charAt(0).toUpperCase() + txt.substr(1).toLowerCase();});
}

function upper(str){
    return str.replace(/^[A-Z]\.[a-z\.]+/, function(txt){return txt.toUpperCase()});
}

function calculateAge(start, end, target){

    console.log('start :'+start+' , End :'+end+' , target');
    let e = moment(end, "YYYY-MM-DD");
    let s = moment(start, "YYYY-MM-DD");

    var diff = moment.preciseDiff(s, e);
    target.val(diff);
   
    console.log(diff);
}