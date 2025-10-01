using Domain.Common;
using Domain.Common.Filters;
using Domain.Interfaces;

namespace Application;

public interface IProductRepository
{
    // get, get all, create, update, delete
    ISorter<ProductReadDto> Sorter { get; set; }
    IFilter<ProductReadDto> Filter { get; set; }
    Task<ProductReadDto> GetAsync(int id);
    Task<IEnumerable<ProductReadDto>> GetAllAsync(QueryParams<ProductFilter> query);
}
