using TadbirKish.Domain.Models;

namespace TadbirKish.Persistence
{
	public class UnitOfWork :
        TadbirKish.Persistence.Base.UnitOfWork<DatabaseContext>, IUnitOfWork
	{
		public UnitOfWork
			(TadbirKish.Persistence.Base.Options options) : base(options: options)
        {
        }

		private RequestRegistrations.Repositories.IRequestRegistrationRepository _requestRegistrations;

		public RequestRegistrations.Repositories.IRequestRegistrationRepository RequestRegistrations
        {
			get
			{
				if (_requestRegistrations == null)
				{
                    _requestRegistrations =
						new RequestRegistrations.Repositories.RequestRegistrationRepository(databaseContext: DatabaseContext);
				}

				return _requestRegistrations;
			}
		}

        private Coverages.Repositories.ICoverageRepository _coverages;

        public Coverages.Repositories.ICoverageRepository Coverages
        {
            get
            {
                if (_coverages == null)
                {
                    _coverages =
                        new Coverages.Repositories.CoverageRepository(databaseContext: DatabaseContext);
                }

                return _coverages;
            }
        }

        private CalculationCovers.Repositories.ICalculationCoverRepository _calculationCovers;

        public CalculationCovers.Repositories.ICalculationCoverRepository CalculationCovers
        {
            get
            {
                if (_calculationCovers == null)
                {
                    _calculationCovers =
                        new CalculationCovers.Repositories.CalculationCoverRepository(databaseContext: DatabaseContext);
                }

                return _calculationCovers;
            }
        }

    }
}
