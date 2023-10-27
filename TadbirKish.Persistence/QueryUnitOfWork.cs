using TadbirKish.Domain.Models;

namespace TadbirKish.Persistence
{
	public class QueryUnitOfWork :
        TadbirKish.Persistence.Base.QueryUnitOfWork<QueryDatabaseContext>, IQueryUnitOfWork
	{
		public QueryUnitOfWork
			(TadbirKish.Persistence.Base.Options options) : base(options: options)
        {
        }

		private RequestRegistrations.Repositories.IRequestRegistrationQueryRepository _requestRegistrations;

		public RequestRegistrations.Repositories.IRequestRegistrationQueryRepository RequestRegistrations
        {
			get
			{
				if (_requestRegistrations == null)
				{
                    _requestRegistrations =
						new RequestRegistrations.Repositories.RequestRegistrationQueryRepository(databaseContext: DatabaseContext);
				}

				return _requestRegistrations;
			}
		}

        private Coverages.Repositories.ICoverageQueryRepository _coverages;

        public Coverages.Repositories.ICoverageQueryRepository Coverages
        {
            get
            {
                if (_coverages == null)
                {
                    _coverages =
                        new Coverages.Repositories.CoverageQueryRepository(databaseContext: DatabaseContext);
                }

                return _coverages;
            }
        }

        private CalculationCovers.Repositories.ICalculationCoverQueryRepository _calculationCovers;

        public CalculationCovers.Repositories.ICalculationCoverQueryRepository CalculationCovers
        {
            get
            {
                if (_calculationCovers == null)
                {
                    _calculationCovers =
                        new CalculationCovers.Repositories.CalculationCoverQueryRepository(databaseContext: DatabaseContext);
                }

                return _calculationCovers;
            }
        }
    }
}
