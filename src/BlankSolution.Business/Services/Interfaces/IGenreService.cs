using BlankSolution.Core.Entities;

namespace BlankSolution.Business.Services.Interfaces;

public interface IGenreService
{
    Task<IEnumerable<Genre>> GetAllAsync();
    Task<Genre> CreateAsync(Genre genre);
    Task<Genre> UpdateAsync(Genre genre);
    Task DeleteAsync(Guid id);
    Task<Genre> GetByIdAsync(Guid id);
}
