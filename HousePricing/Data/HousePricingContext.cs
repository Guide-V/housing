using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HousePricing.Models;

namespace HousePricing.Data
{
    public class HousePricingContext : DbContext
    {
        public HousePricingContext (DbContextOptions<HousePricingContext> options)
            : base(options)
        {
        }

        public DbSet<HousePricing.Models.House> House { get; set; } = default!;
    }
}
