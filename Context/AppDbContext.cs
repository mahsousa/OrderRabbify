using Microsoft.EntityFrameworkCore;
using OrderRabbify.Models;

namespace OrderRabbify.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
        }
        public DbSet<ItemModel> Items { get; set; }
        public DbSet<OrderModel> Orders { get; set; }
    }
}
