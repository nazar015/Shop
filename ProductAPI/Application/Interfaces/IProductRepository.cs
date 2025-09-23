using Domain.Common;
using Domain.Interfaces;

namespace Application;

public interface IProductRepository
{
    // get, get all, create, update, delete
    ISorter<ProductReadDto> Sorter { get; set; }
    Task<ProductReadDto> GetAsync(int id);
    Task<ProductReadDto> GetAllAsync(QueryParams query);
}
