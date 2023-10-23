using Microsoft.AspNetCore.Mvc;
using ru.htt.apiServer.Core.Abstractions.Repositories;
using ru.htt.apiServer.Core.Domain;
using ru.htt.apiServer.Models;

namespace ru.htt.apiServer.Controllers;

/// <summary>
/// Продукты
/// </summary>
[ApiController]
[Route("api/v1/[controller]")]
public class ProductController: ControllerBase {
    private readonly IRepository<Product> _productRepository;

    public ProductController(IRepository<Product> productRepository) {
        _productRepository = productRepository;
    }
    /// <summary>
    /// Получить список всех продуктов
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<ActionResult<List<ProductResponse>>> GetProductsAsync() {
        var products = await _productRepository.GetAllAsync();
        var productResponse = products.Select(x => new ProductResponse() {
                Id = x.Id,
                CategoryId = x.CategoryId,
                ProductName = x.ProductName,
                Price = x.Price,
            }
        ).ToList();
        return Ok(productResponse);
    }
}