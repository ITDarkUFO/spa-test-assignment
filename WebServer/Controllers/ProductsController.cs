using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using WebServer.DTOs;
using WebServer.Models;
using WebServer.Resources;
using WebServer.Services;

namespace WebServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(ILogger<ProductsContext> logger, IStringLocalizer<SharedResources> localizer, IMapper mapper, ProductsService productsService) : ControllerBase
    {
        private readonly ILogger<ProductsContext> _logger = logger;
        private readonly IStringLocalizer<SharedResources> _localizer = localizer;
        private readonly IMapper _mapper = mapper;
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
                return BadRequest(_localizer["UnknownError"].Value);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] ProductDTO product)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                await _productsService.AddProductAsync(_mapper.Map<Product>(product));
                return Ok(_localizer["ProductSuccessfullyAdded"].Value);
            }
            catch (Exception ex)
            {
                _logger.LogCritical("Возникла неизвестная ошибка:\n{ex}", ex);
                return BadRequest(_localizer["UnknownError"].Value);
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] Product product)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            try
            {
                await _productsService.UpdateProductAsync(id, product);
                return Ok(_localizer["ProductSuccessfullyUpdated"].Value);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                _logger.LogWarning("Возникла ошибка при сохранении изменений:\n{ex}", ex);
                return BadRequest(_localizer["ErrorWhileSavingChanges"].Value);
            }
            catch (Exception ex)
            {
                _logger.LogCritical("Возникла неизвестная ошибка:\n{ex}", ex);
                return BadRequest(_localizer["UnknownError"].Value);
            }
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            try
            {
                await _productsService.DeleteProductAsync(id);
                return Ok(_localizer["ProductSuccessfullyRemoved"].Value);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
