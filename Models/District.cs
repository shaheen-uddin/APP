using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AppProject.Models
{
    public class District
    {
        public int ID { get; set;}
        [Required]
        [StringLength(100)]
        public string  Name { get; set; }
    }
}