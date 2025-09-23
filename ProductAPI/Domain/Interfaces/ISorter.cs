using Domain.Common;

namespace Domain.Interfaces;

public interface ISorter<T>
{
    public void Apply(IQueryable<T> collection, string field, SortDirection direction);
}
