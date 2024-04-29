using BlankSolution.Business.DTO_s.MovieDTO_s;
using BlankSolution.Core.Entities;

namespace BlankSolution.Business.Services.Interfaces;

public interface IMovieService
{
    Task<MovieGetDto> GetByIdAsync(int id);
    Task CreateAsync(MovieCreateDto dto);
    Task<IEnumerable<MovieGetDto>> GetAllAsync();
    Task UpdateAsync(int id, MoviePutDto moviePutDto);
    Task DeleteAsync(int id, MovieDeleteDto movieDeleteDto);
    Task<object?> CreateAsync(Movie movie);
    Task UpdateAsync(int id, Movie movie);
}
