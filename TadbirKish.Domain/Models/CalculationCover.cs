using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace TadbirKish.Domain.Models
{
    public class CalculationCover: Base.Entity
    {
        [Required]
        public int CoverageCode { get; set; }

        [Required]
        public double Fund { get; set; }

        public double Calculated { get; set; }

        public Guid RequestRegistrationId { get; set; } 
        public RequestRegistration RequestRegistration { get; set; }
    }
}
