namespace Domain.Common;

public class QueryParams<TFilter>
{
    public int Page { get; set; }
    public int Size { get; set; }
    public string Search { get; set; }
    public string SortField { get; set; }
    public SortDirection SortOrder { get; set; }
    public TFilter Filter { get; set; }
}
