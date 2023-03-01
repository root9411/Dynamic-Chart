using Daynamic_Chart.Models;
using Microsoft.EntityFrameworkCore;

namespace Daynamic_Chart.DataLayer
{
    public class DbContextSales : DbContext
    {
        public DbContextSales(DbContextOptions options) : base(options)
        {
        }

        public DbSet<SalesEntity> SalesData { get; set; }
    }
}
