using MadBand.WebApp.Models.Entities;

namespace MadBand.WebApp.Models.Data.Context.Repositories
{
	public interface IRepository<TEntityType>
	{
		TEntityType Create(TEntityType entity);
		TEntityType Delete(int id);
		TEntityType Delete(TEntityType entity);
		TEntityType GetEntity(int id);
		//IEnumerable<TEntityType> GetAll()  
		void Update(TEntityType entity);
	}
}