namespace Domain.Common;

public class QueryParams
{
    public int Page { get; set; }
    public int Size { get; set; }
    public string Search { get; set; }
    public string SortField { get; set; }
    public SortDirection SortOrder { get; set; }
}
