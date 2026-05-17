using Products.Domain.Products;

namespace Products.Application.Products
{
    public class AddProductsHandler
    {
        public Task<AddProductsResponse> Handle(AddProductsRequest request)
        {
            return Task.FromResult(new AddProductsResponse
            {
                IsSuccess = true
            });
        }
    }
}
