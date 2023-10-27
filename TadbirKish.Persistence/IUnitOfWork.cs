using TadbirKish.Domain.Models;
using TadbirKish.Persistence.CalculationCovers.Repositories;
using TadbirKish.Persistence.Coverages.Repositories;
using TadbirKish.Persistence.RequestRegistrations.Repositories;

namespace TadbirKish.Persistence
{
    public interface IUnitOfWork : TadbirKish.Persistence.Base.IUnitOfWork
    {
        public IRequestRegistrationRepository RequestRegistrations { get; }
        public ICoverageRepository Coverages { get; }
        public ICalculationCoverRepository CalculationCovers { get; }
    }
}
