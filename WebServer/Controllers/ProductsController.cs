using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebServer.Models;
using WebServer.Services;

namespace WebServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(ILogger<ProductsContext> logger, ProductsService productsService) : ControllerBase
    {
        private readonly ILogger<ProductsContext> _logger = logger;
        private readonly ProductsService _productsService = productsService;

        [HttpGet]
        public async Task<IActionResult> GetProduct(int id)
        {
            try
            {
                var product = await _productsService.GetProductByIdAsync(id);
                return Ok(product);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogCritical("Возникла неизвестная ошибка:\n{ex}", ex);
                return BadRequest("Возникла неизвестная ошибка");
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {
            try
            {
                await _productsService.AddProductAsync(product);

                return Ok("Продукт успешно добавлен");
            }
            catch (Exception ex)
            {
                _logger.LogCritical("Возникла неизвестная ошибка:\n{ex}", ex);
                return BadRequest("Возникла неизвестная ошибка");
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(Product product)
        {
            try
            {
                await _productsService.UpdateProductAsync(product);

                return Ok("Продукт успешно обновлен");
            }
            catch (Exception ex)
            {
                _logger.LogCritical("Возникла неизвестная ошибка:\n{ex}", ex);
                return BadRequest("Возникла неизвестная ошибка");
            }
        }
    }
}
