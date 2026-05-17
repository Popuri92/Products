using System;
using System.Collections.Generic;
using System.Text;

namespace Products.Domain.Products
{
    public record GetProductsRequest(string? Filter = null);
}
