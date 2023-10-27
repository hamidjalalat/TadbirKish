using TadbirKish.Domain.Models.Base;

namespace TadbirKish.Persistence.Base
{
	public interface IQueryRepository<T> where T :IEntity
	{
		Task<T> GetByIdAsync(System.Guid id);

		Task<IList<T>> GetAllAsync();
	}
}
