using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using WebServer.Models;
using WebServer.Resources;

namespace WebServer.Services
{
    public class ProductsService(ILogger<ProductsService> logger, IStringLocalizer<SharedResources> localizer, ProductsContext context)
    {
        private readonly ILogger<ProductsService> _logger = logger;
        private readonly IStringLocalizer<SharedResources> _localizer = localizer;
        private readonly ProductsContext _context = context;

        public async Task<int> GetProductsCountAsync()
        {
            var productsCount = await _context.Products.CountAsync();
            return productsCount;
        }

        public async Task<List<Product>> GetProductsAsync(int page, int pageSize)
        {
            if (page <= 0)
                throw new ArgumentException(_localizer["NonPositiveValueError", nameof(page)]);

            if (pageSize <= 0)
                throw new ArgumentException(_localizer["NonPositiveValueError", nameof(pageSize)]);

            var products = await _context.Products.OrderBy(p => p.Id).Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            return products;
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (product is null)
                throw new KeyNotFoundException(_localizer["ProductNotFound"].Value);

            return product;
        }

        public async Task AddProductAsync(Product product)
        {
            _context.Add(product);
            await _context.SaveChangesAsync();
            _logger.LogInformation("Добавлен продукт\n\t{id}: {vendorcode} - {name}", product.Id, product.Vendorcode, product.Name);
        }

        public async Task UpdateProductAsync(int id, Product product)
        {
            if (id != product.Id)
                throw new KeyNotFoundException(_localizer["ProductNotFound"].Value);

            if (!ProductExists(id))
                throw new KeyNotFoundException(_localizer["ProductNotFound"].Value);

            try
            {
                _context.Update(product);
                await _context.SaveChangesAsync();
                _logger.LogInformation("Обновлен продукт\n\t{id}: {vendorcode} - {name}", product.Id, product.Vendorcode, product.Name);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!ProductExists(product.Id))
                {
                    throw new KeyNotFoundException(_localizer["ProductHasBeenDeleted"].Value);
                }
                else
                {
                    _logger.LogWarning("Возникла ошибка при сохранении изменений:\n{ex}", ex);
                    throw;
                }
            }
        }

        public async Task DeleteProductAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);

            if (product is null)
                throw new KeyNotFoundException(_localizer["ProductNotFound"].Value);

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            _logger.LogInformation("Удален продукт\n\t{id}: {vendorcode} - {name}", product.Id, product.Vendorcode, product.Name);
        }

        private bool ProductExists(int id)
        {
            return _context.Products.AsNoTracking().Any(e => e.Id == id);
        }
    }
}
