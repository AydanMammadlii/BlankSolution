using BlankSolution.Business.DTO_s.MovieDTO_s;
using BlankSolution.Business.Services.Interfaces;
using BlankSolution.Core.Entities;
using BlankSolution.Data.Contexts;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace BlankSolution.API.Controllers;

public class MovieController : ControllerBase
{
    private readonly AppDbContext _appDbContext;

    public MovieController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    [HttpGet("")]
    public async Task<IActionResult> GetAll()
    {
        var movies = await _appDbContext.Movies.ToListAsync();
        List<MovieGetDto> movieDTOs = new List<MovieGetDto>();

        movieDTOs = movies.Select(m => new MovieGetDto()
        {
            Id = m.Id,
            Name = m.Name,
            Description = m.Description,
            CostPrice = m.CostPrice,
            SalePrice = m.SalePrice,

        }).ToList();

        //foreach (var movie in movies)
        //{
        //    MovieGetDto dto = new MovieGetDto()
        //    {
        //        Id = movie.Id,
        //        Name = movie.Name,
        //        Description = movie.Description,
        //        GenreId = movie.GenreId,
        //        Price = movie.Price
        //    };
        //}

        return Ok(movieDTOs);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var movie = await _appDbContext.Movies.FindAsync(id);
        if (movie == null) return NotFound();

        MovieGetDto movieGetDto = new MovieGetDto()
        {
            Id = movie.Id,
            Name = movie.Name,
            Description = movie.Description,
            SalePrice = movie.SalePrice
        };

        return Ok(movieGetDto);
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> Create(MovieCreateDto dto)
    {
        Movie movie = new Movie()
        {
            Name = dto.Name,
            Description = dto.Description,
            CostPrice = dto.CostPrice,
            SalePrice = dto.SalePrice,
            IsDeleted = dto.IsDeleted,
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now
        };

        await _appDbContext.Movies.AddAsync(movie);
        await _appDbContext.SaveChangesAsync();

        return Ok();
    }

    [HttpPut("[action]/{id}")]
    public async Task<IActionResult> Update(int id, MovieUpdateDto dto)
    {
        var movie = await _appDbContext.Movies.FindAsync(id);

        if (movie == null)
        {
            return NotFound();
        }

        movie.Name = dto.Name;
        movie.Description = dto.Description;
        movie.SalePrice = dto.SalePrice;
        movie.CostPrice = dto.CostPrice;
        movie.IsDeleted = dto.IsDeleted;
        movie.UpdatedDate = DateTime.Now;

        await _appDbContext.SaveChangesAsync();

        return Ok();
    }

    [HttpDelete("[action]/{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var movie = await _appDbContext.Movies.FindAsync(id);

        if (movie == null)
        {
            return NotFound();
        }

        movie.IsDeleted = true;
        movie.UpdatedDate = DateTime.Now;

        await _appDbContext.SaveChangesAsync();

        return Ok();
    }


}
