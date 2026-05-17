using Microsoft.AspNetCore.Mvc;
using Products.Domain.Products;
using Wolverine;

namespace Products.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(IMessageBus messageBus) : ControllerBase
    {
        private readonly IMessageBus _messageBus = messageBus;

        [HttpGet("GetProducts")]      
        public async Task<ActionResult<GetProductsResponse>> GetProducts()

        {
            var reponse = await _messageBus.InvokeAsync<GetProductsResponse>(new GetProductsRequest());
            if (reponse == null)
            {
                return NotFound();
            }
            return Ok(reponse);
        }

        [HttpGet("AddProducts")]
        public async Task<ActionResult<AddProductsResponse>> AddProducts()

        {
            var reponse = await _messageBus.InvokeAsync<AddProductsResponse>(new AddProductsRequest());
            if (reponse == null)
            {
                return NotFound();
            }
            return Ok(reponse);
        }
    }
}
