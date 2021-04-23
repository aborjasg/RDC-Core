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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=WIN-DAPHNE\\SQLEXPRESS2016;Database=rdcomuni_sqlbd_uat;User ID=sa;Password=P@ssw0rd;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<SystemUser>(entity =>
            {
                entity.HasKey(e => e.SSystemUserId);

                entity.ToTable("SystemUser", "Configuration");

                entity.Property(e => e.SSystemUserId).HasColumnName("sSystemUserId");

                entity.Property(e => e.BActive).HasColumnName("bActive");

                entity.Property(e => e.BStatus).HasColumnName("bStatus");

                entity.Property(e => e.SRolTypeId).HasColumnName("sRolTypeId");

                entity.Property(e => e.VAlias)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("vAlias");

                entity.Property(e => e.VOptions)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vOptions");

                entity.Property(e => e.VPassword)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("vPassword");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
