using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AppProject.Models
{
    public class LoginModel
    {
        [DataType(DataType.EmailAddress)]
        [Required]
        public string Email { get; set;}
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set;}
        public bool RememberMe { get; set;}
    }
}