﻿namespace BlazorEcommerce.Server.Services.ProductService
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();
        Task<ServiceResponse<Product>> GetProductAsync(int productId);
        Task<ServiceResponse<List<Product>>> GetProductByCategories(string categoryUrl);
        Task<ServiceResponse<ProductSearchResult>> SearchProducts(string seacrchText , int page);
    }
}
