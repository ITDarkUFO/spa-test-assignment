using Microsoft.EntityFrameworkCore;

namespace WebServer.Models
{
    public class ProductsContext(DbContextOptions<ProductsContext> options) : DbContext(options)
    {
        public virtual DbSet<Product> Products { get; set; }
    }
}
