using Azure.Core;
using Azure;
using BlankSolution.Business.DTO_s.GenreDTO_s;
using BlankSolution.Business.Services.Interfaces;
using BlankSolution.Core.Entities;
using BlankSolution.Core.Repositories;
using BlankSolution.Data.Repostories;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Buffers.Text;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System;
using System.Data.Entity;

namespace BlankSolution.Business.Services.Implementations;

public class GenreService : IGenreService
{
    public Task<Genre> CreateAsync(Genre genre)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Genre>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Genre> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Genre> UpdateAsync(Genre genre)
    {
        throw new NotImplementedException();
    }
}
