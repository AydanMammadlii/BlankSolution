namespace BlankSolution.Business.DTO_s.MovieDTO_s;

public class MoviePutDto
{
    public int Id { get; set; }
    public int GenreId { get; set; }
    public string Name { get; set; }
    public string Desc { get; set; }
    public double CostPrice { get; set; }
    public double SalePrice { get; set; }
    public bool IsDeleted { get; set; }
}
