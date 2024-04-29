using BlankSolution.Business.DTO_s.GenreDTO_s;
using BlankSolution.Business.Services.Interfaces;
using BlankSolution.Core.Entities;
using BlankSolution.Data.Contexts;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace BlankSolution.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GenresController : ControllerBase
{
    private readonly AppDbContext _appDbContext;

    public GenresController(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    [HttpGet("")]
    public async Task<IActionResult> GetAll()
    {
        var genres = await _appDbContext.Genres.ToListAsync();
        List<GenreGetListDto> genreDTOs = new List<GenreGetListDto>();

        genreDTOs = genres.Select(m => new GenreGetListDto()
        {
            Id = m.Id,
            Name = m.Name
        }).ToList();

        return Ok(genreDTOs);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var genre = await _appDbContext.Genres.FindAsync(id);
        if (genre == null) return NotFound();

        GenreGetListDto genreGetDto = new GenreGetListDto()
        {
            Id = genre.Id,
            Name = genre.Name,
        };

        return Ok(genreGetDto);
    }

    public async Task<IActionResult> Create(GenreCreateDto dto)
    {
        Genre genre = new Genre()
        {
            Name = dto.Name,
            CreatedDate = DateTime.Now,
            UpdatedDate = DateTime.Now
        };

        await _appDbContext.Genres.AddAsync(genre);
        await _appDbContext.SaveChangesAsync();

        return Ok();
    }

    [HttpPut("[action]/{id}")]
    public async Task<IActionResult> Update(int id, GenreUpdateDto dto)
    {
        var genre = await _appDbContext.Genres.FindAsync(id);

        if (genre == null)
        {
            return NotFound();
        }

        genre.Name = dto.Name;
        genre.IsDeleted = dto.IsDeleted;
        genre.UpdatedDate = DateTime.Now;

        await _appDbContext.SaveChangesAsync();

        return Ok();
    }

    [HttpDelete("[action]/{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var genre = await _appDbContext.Genres.FindAsync(id);

        if (genre == null)
        {
            return NotFound();
        }

        genre.IsDeleted = true;
        genre.UpdatedDate = DateTime.Now;

        await _appDbContext.SaveChangesAsync();

        return Ok();
    }
}
