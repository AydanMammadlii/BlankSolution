namespace BlankSolution.Core.Entities;

public class Movie : BaseEntity
{
    public int GenreId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double CostPrice { get; set; }
    public double SalePrice { get; set; }

    public Genre Genre { get; set; }
}
