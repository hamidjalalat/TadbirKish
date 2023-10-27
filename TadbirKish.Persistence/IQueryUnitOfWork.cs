using TadbirKish.Domain.Models;

namespace TadbirKish.Persistence
{
    public interface IQueryUnitOfWork : TadbirKish.Persistence.Base.IQueryUnitOfWork
    {
        public RequestRegistrations.Repositories.IRequestRegistrationQueryRepository RequestRegistrations { get; }
        public Coverages.Repositories.ICoverageQueryRepository Coverages { get; }
        public CalculationCovers.Repositories.ICalculationCoverQueryRepository CalculationCovers { get; }
    }
}
