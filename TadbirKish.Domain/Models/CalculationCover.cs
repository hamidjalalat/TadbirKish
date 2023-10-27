using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TadbirKish.Domain.Models
{
    public class CalculationCover: Base.Entity
    {
        [System.ComponentModel.DataAnnotations.Required]
        public int CoverageCode { get; set; }

        [System.ComponentModel.DataAnnotations.Required]
        public double Fund { get; set; }

        public double Calculated { get; set; }

        public Guid RequestRegistrationId { get; set; } 
        public RequestRegistration RequestRegistration { get; set; }
    }
}
