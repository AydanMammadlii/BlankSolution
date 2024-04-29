using BlankSolution.Business.CustomExceptions.CommonException;
using BlankSolution.Business.Services.Interfaces;
using BlankSolution.Core.Entities;
using BlankSolution.Core.Repositories;
using BlankSolution.Business.DTO_s.MovieDTO_s;


namespace BlankSolution.Business.Services.Implementations;

public class MovieService : IMovieService
{
    private readonly IMovieRepository _movieRepository;

    public MovieService(IMovieRepository movieRepository)
    {
        _movieRepository = movieRepository;
    }
    public async Task<IEnumerable<Movie>> GetAllAsync()
    {
        return await _movieRepository.GetAllAsync();
    }
    public async Task<Movie> GetByIdAsync(int id)
    {
        return await _movieRepository.GetByIdAsync(id);
    }
    public async Task<Movie> CreateAsync(Movie movie)
    {
        if (_movieRepository.Table.Any(x => x.Name == movie.Name))
        {
            throw new Exception("Name is already exist");
        }

        await _movieRepository.InsertAsync(movie);
        await _movieRepository.CommitAsync();

        return movie;
    }

    public async Task<Movie> DeleteAsync(Movie movie)
    {
        if (_movieRepository.Table.Any(x => x.Name == movie.Name))
        {
            throw new Exception("Name is already exist");
        }

        await _movieRepository.DeleteAsync(movie);
        await _movieRepository.SaveChangesAsync();

        return movie;
    }
}

    