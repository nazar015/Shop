namespace Domain.Objects;

public class Product
{
    public int Id { get; set; }
    public string Title { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public bool IsSoldOut { get; set; }
    public bool IsHidden { get; set; }
    public IEnumerable<Image> Images { get; set; }
}
