using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TadbirKish.Domain.Models
{
    public class RequestRegistration : Base.Entity
    {
        public RequestRegistration() : base()
        {
        }
         
        [Required]
        public string Subject { get; set; }

        public IList<CalculationCover> CalculationCovers { get; set; }

    }
}
