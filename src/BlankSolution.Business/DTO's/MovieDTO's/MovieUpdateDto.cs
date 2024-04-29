namespace BlankSolution.Business.DTO_s.MovieDTO_s;

public class MovieUpdateDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public double CostPrice { get; set; } 
    public double SalePrice { get; set; } 
    public bool IsDeleted { get; set; }
}

