namespace BikeRentalPoint.Domain;

public interface IRepository<TEntity, TKey>
    where TEntity : class
    where TKey : struct
{
    public Task<TEntity> Create(TEntity entity);

    public Task<TEntity?> Get(TKey entityId);

    public Task<IList<TEntity>> GetAll();

    public Task<TEntity> Update(TEntity entity);

    public Task<bool> Delete(TKey entityId);
}