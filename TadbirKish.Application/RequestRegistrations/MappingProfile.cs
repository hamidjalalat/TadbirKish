using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TadbirKish.Application.CalculationCovers.Commands;
using TadbirKish.Application.CalculationCovers.Queries;
using TadbirKish.Application.Coverages.Commands;
using TadbirKish.Application.RequestRegistrations.Commands;
using TadbirKish.Domain.Models;

namespace TadbirKish.Application.Users
{
    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile() : base()
        {
            CreateMap<CreateRequestRegistrationCommand, RequestRegistration>();
            CreateMap<RequestRegistration, CreateRequestRegistrationCommand>();

            CreateMap<CreateCoverageCommand, Coverage>();
            CreateMap<Coverage, CreateCoverageCommand>();  
            
            CreateMap<CreateCalculationCoverCommand, CalculationCover>();
            CreateMap<CalculationCover, CreateCalculationCoverCommand>();
        }
    }
}
