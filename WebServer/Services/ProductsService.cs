using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using WebServer.Models;

namespace WebServer.Services
{
    public class ProductsService(ILogger<ProductsService> logger, ProductsContext context)
    {
        private readonly ILogger<ProductsService> _logger = logger;
        private readonly ProductsContext _context = context;

        public async Task<Product> GetProductByIdAsync(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (product is null) 
            {
                _logger.LogWarning("Запрошенный продукт с id: {id} не найден", id);
                throw new KeyNotFoundException("Указанный продукт не найден");
            }

            return product;
        }

        public async Task AddProductAsync(Product product)
        {
            _context.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProductAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
