using Domain.Common;
using Domain.Common.Filters;
using Domain.Interfaces;
using MediatR;

namespace Application.Features;

public class GetProductsQuery : IRequest<IEnumerable<ProductReadDto>?>
{
    public QueryParams<ProductFilter> Query { get; set; }
}
