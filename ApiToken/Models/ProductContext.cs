using Microsoft.EntityFrameworkCore;

namespace ApiToken.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }

        public DbSet<Product>Products { get; set; }
    }
}
