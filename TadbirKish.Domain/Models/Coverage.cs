using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TadbirKish.Domain.Models
{
    public class Coverage:Base.Entity
    {
        [System.ComponentModel.DataAnnotations.Required]
        public int Code { get; set; }


        [System.ComponentModel.DataAnnotations.Required]
        public string  Name { get; set; } 


        [System.ComponentModel.DataAnnotations.Required]
        public double Rate { get; set; }
  
    }
}
