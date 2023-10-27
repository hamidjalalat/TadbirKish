

using System.Resources;
using TadbirKish.Domain.Models;

namespace TadbirKish.Application.RequestRegistrations.CommandHandlers
{
	public class CreateRequestRegistrationCommandHandler :Mediator.IRequestHandler
		<Commands.CreateRequestRegistrationCommand, System.Guid>
	{
		public CreateRequestRegistrationCommandHandler
			(
			AutoMapper.IMapper mapper,
			Persistence.IUnitOfWork unitOfWork) : base()
		{
			Mapper = mapper;
			UnitOfWork = unitOfWork;
		}

		protected AutoMapper.IMapper Mapper { get; }

		protected Persistence.IUnitOfWork UnitOfWork { get; }

		

		public async Task<FluentResults.Result<System.Guid>>
			Handle(Commands.CreateRequestRegistrationCommand request,
			CancellationToken cancellationToken)
		{
			var result =
				new FluentResults.Result<System.Guid>();

			try
			{
                var RequestRegistration = Mapper.Map<Domain.Models.RequestRegistration>(source: request);
             
                await UnitOfWork.RequestRegistrations.InsertAsync(entity: RequestRegistration);

				foreach (var item in request.CreateCalculationCoverCommands.Where(C=>C.Selected))
				{
                    var temp = new CalculationCover();
					temp.RequestRegistrationId = RequestRegistration.Id;
					temp.Fund = item.Fund;
					temp.CoverageCode = item.Code;
					temp.Calculated = item.Fund * item.Rate;
                    await UnitOfWork.CalculationCovers.InsertAsync(entity: temp);
                }


                await UnitOfWork.SaveAsync();

                result.WithValue(value: RequestRegistration.Id);
                string successInsert =
                    string.Format("عملیات درج با موفقیت انجام شد");

                result.WithSuccess
                    (successMessage: successInsert);
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
