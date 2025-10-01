using Domain.Common;
using Domain.Common.Filters;
using Domain.Interfaces;
using MediatR;

namespace Application.Features;

public class GetProductsHandler : IRequestHandler<GetProductsQuery, IEnumerable<ProductReadDto>?>
{
    private readonly IProductRepository _productRepository;

    public GetProductsHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<IEnumerable<ProductReadDto>?> Handle(GetProductsQuery request, CancellationToken cancellationToken)
    {
        var results = await _productRepository.GetAllAsync(request.Query);
        return results;
    }
}
