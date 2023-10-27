using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TadbirKish.Domain.Models
{
    public class Coverage:Base.Entity
    {
        [Required]
        public int Code { get; set; }


        [Required]
        public string  Name { get; set; } 


        [Required]
        public double Rate { get; set; }
  
    }
}
