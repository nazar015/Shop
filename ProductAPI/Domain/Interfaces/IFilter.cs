using Domain.Common;

namespace Domain.Interfaces;

public interface IFilter<T>
{
    public void Apply(IQueryable<T> collection, string[] field);
}
