using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RDC.API.SystemUsers.Models;

namespace RDC.API.SystemUsers.Data
{
    public partial class RDCContext : DbContext
    {
        public RDCContext(DbContextOptions<RDCContext> options) : base(options)
        {
        }
        public virtual DbSet<SystemUser> SystemUsers { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SystemUser>(entity =>
            {
                entity.ToTable("SystemUser", "Configuration");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        
    }
}
