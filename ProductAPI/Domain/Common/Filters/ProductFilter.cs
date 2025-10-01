namespace Domain.Common.Filters;

public class ProductFilter
{
    public string Title { get; set; }
    public bool IsSoldOut { get; set; }
    public bool IsHidden { get; set; }
    public DateTime After { get; set; }
    public DateTime Before { get; set; }
}
