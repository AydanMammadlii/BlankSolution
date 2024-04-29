namespace BlankSolution.Business.DTO_s.MovieDTO_s;

public class MovieCreateDto
{
    public int GenreId { get; set; }
    public string Name { get; set; }
    public string Desc { get; set; }
    public double CostPrice { get; set; } // 40
    public double SalePrice { get; set; } // 40>
    public bool IsDeleted { get; set; }
    public string Description { get; set; }
}

