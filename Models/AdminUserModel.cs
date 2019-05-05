using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AppProject.Models
{
    public class AdminUserModel
    {
        [DataType(DataType.EmailAddress)]
        [StringLength(100)]
        [Required]
        public string Email { get;set;}
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set;}

        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set;}
    }
}