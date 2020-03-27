using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KENDO.MVVM.Entities
{
    public class KendoMvvmDbContext : DbContext
    {
        public KendoMvvmDbContext(DbContextOptions<KendoMvvmDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
