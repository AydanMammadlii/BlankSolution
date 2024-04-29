using BlankSolution.Core.Entities;
using BlankSolution.Core.Repositories;
using BlankSolution.Data.Contexts;

namespace BlankSolution.Data.Repostories;

public class GenreRepository : GenericRepository<Genre>, IGenreRepository
{
    public GenreRepository(AppDbContext context) : base(context)
    {
    }

}
    
