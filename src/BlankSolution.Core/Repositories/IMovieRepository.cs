using BlankSolution.Core.Entities;

namespace BlankSolution.Core.Repositories;

public interface IMovieRepository : IIGenericRepository<Movie>
{
    Task DeleteAsync(Movie movie);
    Task<Movie> GetByIdAsync(Guid id);
    Task SaveChangesAsync();
}
