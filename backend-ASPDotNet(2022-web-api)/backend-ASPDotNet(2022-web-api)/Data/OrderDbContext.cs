using backend_ASPDotNet_2022_web_api_.Models;
using Microsoft.EntityFrameworkCore;

namespace backend_ASPDotNet_2022_web_api_.Data
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options)
        : base(options)
        {
        }

        public virtual DbSet<Order> Orders { get; set; }
    }
}
