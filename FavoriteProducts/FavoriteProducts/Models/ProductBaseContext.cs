using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FavoriteProducts.Models
{
    public class ProductBaseContext : DbContext
    {
        public ProductBaseContext(DbContextOptions<ProductBaseContext> options) : base(options)
        { }

        public DbSet<ProductBase> ProductBases { get; set; }
    }
}
