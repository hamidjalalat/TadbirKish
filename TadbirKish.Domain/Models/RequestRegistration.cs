using System;
using System.Collections.Generic;
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
         
        [System.ComponentModel.DataAnnotations.Required]
        public string Subject { get; set; }

        public IList<CalculationCover> CalculationCovers { get; set; }

    }
}
