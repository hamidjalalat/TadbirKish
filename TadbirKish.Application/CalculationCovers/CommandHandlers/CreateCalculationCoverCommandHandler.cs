

using System.Resources;

namespace TadbirKish.Application.CalculationCovers.CommandHandlers
{
	public class CreateCalculationCoverCommandHandler : Mediator.IRequestHandler
		<Commands.CreateCalculationCoverCommand, System.Guid>
	{
		public CreateCalculationCoverCommandHandler
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
			Handle(Commands.CreateCalculationCoverCommand request,
			System.Threading.CancellationToken cancellationToken)
		{
			var result =
				new FluentResults.Result<System.Guid>();

			try
			{
                var CalculationCover = Mapper.Map<Domain.Models.CalculationCover>(source: request);
        

                await UnitOfWork.CalculationCovers.InsertAsync(entity: CalculationCover);


                await UnitOfWork.SaveAsync();
         
                result.WithValue(value: CalculationCover.Id);
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
