using Microsoft.EntityFrameworkCore.Storage;
using TadbirKish.Domain.Models;
using TadbirKish.Persistence.ViewModels;

namespace TadbirKish.Application.CalculationCovers.CommandHandlers
{
	public class GetCalculationCoversQueryHandler : object,
		Mediator.IRequestHandler
		<Queries.GetCalculationCoversQuery, System.Collections.Generic.IEnumerable<GetCalculationCoversQueryResponseViewModel>>
	{
		public GetCalculationCoversQueryHandler
            (
			AutoMapper.IMapper mapper,
            TadbirKish.Persistence.IQueryUnitOfWork unitOfWork) : base()
		{
		
			Mapper = mapper;
			UnitOfWork = unitOfWork;
		}

		protected AutoMapper.IMapper Mapper { get; }

		protected TadbirKish.Persistence.IQueryUnitOfWork UnitOfWork { get; }

		

		public
			async
		Task
			<FluentResults.Result
				<IEnumerable
				<GetCalculationCoversQueryResponseViewModel>>>
			Handle(Queries.GetCalculationCoversQuery request, System.Threading.CancellationToken cancellationToken)
		{
			var result =
				new FluentResults.Result
				<System.Collections.Generic.IEnumerable
				<GetCalculationCoversQueryResponseViewModel>>();

			try
			{
                var Coverages =
                await
                UnitOfWork.Coverages
                .GetSomeAsync()
                ;

                var CalculationCovers =
					await
                UnitOfWork.CalculationCovers
                    .GetSomeAsync(requestRegistrationId:request.RequestRegistrationId)
					;
				foreach (var item in CalculationCovers)
				{
					item.Name= Coverages.Where(C=>C.Code==item.CoverageCode).Select(N=>N.Name).FirstOrDefault();
                }

				result.WithValue(value: CalculationCovers);
			
			}
			catch (System.Exception ex)
			{
			

				result.WithError
					(errorMessage: ex.Message);
			}

			return result;
		}

      
    }
}
