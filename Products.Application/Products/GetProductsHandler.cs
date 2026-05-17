using Products.Domain.Products;

namespace Products.Application.Products
{
    public class GetProductsHandler
    {
        public Task<GetProductsResponse> Handle(GetProductsRequest request)
        {
            return Task.FromResult(new GetProductsResponse());
        }
    }
}
