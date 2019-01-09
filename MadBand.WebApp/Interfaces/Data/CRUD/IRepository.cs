namespace MadBand.WebApp.Interfaces.Data.CRUD
{
	public interface IRepository<TEntity> : ICreate<TEntity>, IDelete<TEntity>, IRead<TEntity>, IReadAll<TEntity>, IUpdate<TEntity>
	{

	}
}
