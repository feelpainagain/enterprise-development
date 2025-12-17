namespace BikeRentalPoint.Application.Contracts;

/// <summary>
/// Base interface for application services that provide
/// CRUD operations over entities using DTO models.
/// </summary>
public interface IApplicationService<TDto, TCreateUpdateDto, TKey>
    where TDto : class
    where TCreateUpdateDto : class
    where TKey : struct
{

    /// <summary>
    /// Returns a list of all entities.
    /// </summary>
    public Task<IList<TDto>> GetAll();

    /// <summary>
    /// Returns a single entity by its identifier.
    /// </summary>
    public Task<TDto> Get(TKey id);

    /// <summary>
    /// Creates a new entity based on the provided DTO.
    /// </summary>
    public Task<TDto> Create(TCreateUpdateDto entity);

    /// <summary>
    /// Updates an existing entity by its identifier.
    /// </summary>
    public Task<TDto> Update(TKey id, TCreateUpdateDto entity);

    /// <summary>
    /// Deletes an entity by its identifier.
    /// </summary>
    public Task<bool> Delete(TKey id);
}