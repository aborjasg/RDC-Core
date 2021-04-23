using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RDC.API.SystemParameters.Models;

namespace RDC.API.SystemParameters.Data
{
    public class RDCContext : DbContext
    {
        public RDCContext(DbContextOptions<RDCContext> options) : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerSection> CustomerSections { get; set; }
        public virtual DbSet<MediaPrice> MediaPrices { get; set; }
        public virtual DbSet<Medium> Media { get; set; }
        public virtual DbSet<SystemParameter> SystemParameters { get; set; }
        public virtual DbSet<SystemSection> SystemSections { get; set; }

    }
}
