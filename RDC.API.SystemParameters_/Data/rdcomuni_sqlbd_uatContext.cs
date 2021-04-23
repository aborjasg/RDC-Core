using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RDC.API.SystemParameters.Models;

#nullable disable

namespace RDC.API.SystemParameters.Data
{
    public partial class rdcomuni_sqlbd_uatContext : DbContext
    {
        public rdcomuni_sqlbd_uatContext()
        {
        }

        public rdcomuni_sqlbd_uatContext(DbContextOptions<rdcomuni_sqlbd_uatContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<ArticleElement> ArticleElements { get; set; }
        public virtual DbSet<ArticleElementReference> ArticleElementReferences { get; set; }
        public virtual DbSet<ArticleSection> ArticleSections { get; set; }
        public virtual DbSet<Bulletin> Bulletins { get; set; }
        public virtual DbSet<BulletinArticle> BulletinArticles { get; set; }
        public virtual DbSet<Contact> Contacts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerSection> CustomerSections { get; set; }
        public virtual DbSet<MediaPrice> MediaPrices { get; set; }
        public virtual DbSet<Medium> Media { get; set; }
        public virtual DbSet<SystemParameter> SystemParameters { get; set; }
        public virtual DbSet<SystemSection> SystemSections { get; set; }
        public virtual DbSet<SystemUser> SystemUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=WIN-DAPHNE\\SQLEXPRESS2016;Initial Catalog=rdcomuni_sqlbd_uat;Persist Security Info=True;User ID=sa;Password=P@ssw0rd");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Article>(entity =>
            {
                entity.HasKey(e => e.SArticleId);

                entity.ToTable("Article", "Operation");

                entity.Property(e => e.SArticleId).HasColumnName("sArticleId");

                entity.Property(e => e.BPublish).HasColumnName("bPublish");

                entity.Property(e => e.DRegisterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dRegisterDate");

                entity.Property(e => e.FPriceCost).HasColumnName("fPriceCost");

                entity.Property(e => e.SArticleTypeId).HasColumnName("sArticleTypeId");

                entity.Property(e => e.SAuthorId).HasColumnName("sAuthorId");

                entity.Property(e => e.SMediaId).HasColumnName("sMediaId");

                entity.Property(e => e.SPressSectionId).HasColumnName("sPressSectionId");

                entity.Property(e => e.SStatusId).HasColumnName("sStatusId");

                entity.Property(e => e.STemplateTypeId).HasColumnName("sTemplateTypeId");

                entity.Property(e => e.VBroadcastDuration)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("vBroadcastDuration");

                entity.Property(e => e.VBroadcastHour)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("vBroadcastHour");

                entity.Property(e => e.VBroadcastSource)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("vBroadcastSource");

                entity.Property(e => e.VDescription)
                    .IsUnicode(false)
                    .HasColumnName("vDescription");

                entity.Property(e => e.VPressPage)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("vPressPage");

                entity.Property(e => e.VTitle)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vTitle");

                entity.HasOne(d => d.SMedia)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.SMediaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Article_Media");
            });

            modelBuilder.Entity<ArticleElement>(entity =>
            {
                entity.HasKey(e => e.SArticleElementId);

                entity.ToTable("ArticleElement", "Operation");

                entity.Property(e => e.SArticleElementId).HasColumnName("sArticleElementId");

                entity.Property(e => e.BTitlePage).HasColumnName("bTitlePage");

                entity.Property(e => e.FFileSize).HasColumnName("fFileSize");

                entity.Property(e => e.SArticleId).HasColumnName("sArticleId");

                entity.Property(e => e.SElementTypeId).HasColumnName("sElementTypeId");

                entity.Property(e => e.SOrder).HasColumnName("sOrder");

                entity.Property(e => e.SPixelHeight).HasColumnName("sPixelHeight");

                entity.Property(e => e.SPixelWidth).HasColumnName("sPixelWidth");

                entity.Property(e => e.SStatusId).HasColumnName("sStatusId");

                entity.Property(e => e.SZoomPercentage).HasColumnName("sZoomPercentage");

                entity.Property(e => e.VContain)
                    .IsUnicode(false)
                    .HasColumnName("vContain");

                entity.Property(e => e.VFileId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vFileId");

                entity.Property(e => e.VFileName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("vFileName");

                entity.Property(e => e.VFilePath)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("vFilePath");

                entity.HasOne(d => d.SArticle)
                    .WithMany(p => p.ArticleElements)
                    .HasForeignKey(d => d.SArticleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArticleElement_Article");
            });

            modelBuilder.Entity<ArticleElementReference>(entity =>
            {
                entity.HasKey(e => e.SArticleReferenceId);

                entity.ToTable("ArticleElementReference", "Operation");

                entity.Property(e => e.SArticleReferenceId).HasColumnName("sArticleReferenceId");

                entity.Property(e => e.SArticleElementId).HasColumnName("sArticleElementId");

                entity.Property(e => e.SArticleId).HasColumnName("sArticleId");
            });

            modelBuilder.Entity<ArticleSection>(entity =>
            {
                entity.HasKey(e => e.SArticleSectionId)
                    .HasName("PK_ArticleCategory");

                entity.ToTable("Article_Section", "Operation");

                entity.Property(e => e.SArticleSectionId).HasColumnName("sArticle_SectionId");

                entity.Property(e => e.SArticleId).HasColumnName("sArticleId");

                entity.Property(e => e.SSectionId).HasColumnName("sSectionId");

                entity.Property(e => e.SStatusId).HasColumnName("sStatusId");

                entity.HasOne(d => d.SArticle)
                    .WithMany(p => p.ArticleSections)
                    .HasForeignKey(d => d.SArticleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Article_Section_Article");
            });

            modelBuilder.Entity<Bulletin>(entity =>
            {
                entity.HasKey(e => e.SBulletinId);

                entity.ToTable("Bulletin", "Operation");

                entity.Property(e => e.SBulletinId).HasColumnName("sBulletinId");

                entity.Property(e => e.DRegisterDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dRegisterDate");

                entity.Property(e => e.SAuthorId).HasColumnName("sAuthorId");

                entity.Property(e => e.SCustomerId).HasColumnName("sCustomerId");

                entity.Property(e => e.SStatusId).HasColumnName("sStatusId");

                entity.HasOne(d => d.SCustomer)
                    .WithMany(p => p.Bulletins)
                    .HasForeignKey(d => d.SCustomerId)
                    .HasConstraintName("FK_Bulletin_Customer");
            });

            modelBuilder.Entity<BulletinArticle>(entity =>
            {
                entity.HasKey(e => e.SBulletinArticleId);

                entity.ToTable("BulletinArticle", "Operation");

                entity.Property(e => e.SBulletinArticleId).HasColumnName("sBulletinArticleId");

                entity.Property(e => e.SArticleId).HasColumnName("sArticleId");

                entity.Property(e => e.SBulletinId).HasColumnName("sBulletinId");

                entity.Property(e => e.SStatusId).HasColumnName("sStatusId");

                entity.HasOne(d => d.SArticle)
                    .WithMany(p => p.BulletinArticles)
                    .HasForeignKey(d => d.SArticleId)
                    .HasConstraintName("FK_BulletinArticle_Article");

                entity.HasOne(d => d.SBulletin)
                    .WithMany(p => p.BulletinArticles)
                    .HasForeignKey(d => d.SBulletinId)
                    .HasConstraintName("FK_BulletinArticle_Bulletin");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.HasKey(e => e.SContactId);

                entity.ToTable("Contact", "Master");

                entity.Property(e => e.SContactId).HasColumnName("sContactId");

                entity.Property(e => e.SCustomerId).HasColumnName("sCustomerId");

                entity.Property(e => e.SStatusId).HasColumnName("sStatusId");

                entity.Property(e => e.VCellphone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vCellphone");

                entity.Property(e => e.VEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vEmail");

                entity.Property(e => e.VName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vName");

                entity.Property(e => e.VTelephone)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vTelephone");

                entity.HasOne(d => d.SCustomer)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.SCustomerId)
                    .HasConstraintName("FK_Contact_Customer");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.SCustomerId);

                entity.ToTable("Customer", "Master");

                entity.Property(e => e.SCustomerId).HasColumnName("sCustomerId");

                entity.Property(e => e.SStatusId).HasColumnName("sStatusId");

                entity.Property(e => e.VAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vAddress");

                entity.Property(e => e.VCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("vCode");

                entity.Property(e => e.VLogoFile)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vLogoFile");

                entity.Property(e => e.VName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vName");
            });

            modelBuilder.Entity<CustomerSection>(entity =>
            {
                entity.HasKey(e => e.SCustomerSectionId);

                entity.ToTable("Customer_Section", "Master");

                entity.Property(e => e.SCustomerSectionId).HasColumnName("sCustomer_SectionId");

                entity.Property(e => e.SCustomerId).HasColumnName("sCustomerId");

                entity.Property(e => e.SOrder).HasColumnName("sOrder");

                entity.Property(e => e.SSectionId).HasColumnName("sSectionId");

                entity.Property(e => e.SStatusId).HasColumnName("sStatusId");

                entity.HasOne(d => d.SCustomer)
                    .WithMany(p => p.CustomerSections)
                    .HasForeignKey(d => d.SCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_Section_Customer");
            });

            modelBuilder.Entity<MediaPrice>(entity =>
            {
                entity.HasKey(e => e.SMediaPriceId);

                entity.ToTable("MediaPrice", "Master");

                entity.Property(e => e.SMediaPriceId).HasColumnName("sMediaPriceId");

                entity.Property(e => e.DFinishDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dFinishDate");

                entity.Property(e => e.DStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("dStartDate");

                entity.Property(e => e.FAxisX).HasColumnName("fAxisX");

                entity.Property(e => e.FAxisY).HasColumnName("fAxisY");

                entity.Property(e => e.FPriceUnit).HasColumnName("fPriceUnit");

                entity.Property(e => e.SMediaId).HasColumnName("sMediaId");

                entity.Property(e => e.SStatus).HasColumnName("sStatus");
            });

            modelBuilder.Entity<Medium>(entity =>
            {
                entity.HasKey(e => e.SMediaId);

                entity.ToTable("Media", "Master");

                entity.Property(e => e.SMediaId).HasColumnName("sMediaId");

                entity.Property(e => e.DPrice).HasColumnName("dPrice");

                entity.Property(e => e.FAxisX).HasColumnName("fAxisX");

                entity.Property(e => e.FAxisY).HasColumnName("fAxisY");

                entity.Property(e => e.FPriceUnit).HasColumnName("fPriceUnit");

                entity.Property(e => e.SMediaTypeId).HasColumnName("sMediaTypeId");

                entity.Property(e => e.SStatusId).HasColumnName("sStatusId");

                entity.Property(e => e.VLogoFile)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vLogoFile");

                entity.Property(e => e.VName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("vName");

                entity.Property(e => e.VReadership)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("vReadership");
            });

            modelBuilder.Entity<SystemParameter>(entity =>
            {
                entity.HasKey(e => e.SParameterId);

                entity.ToTable("SystemParameter", "Configuration");

                entity.Property(e => e.SParameterId)
                    .ValueGeneratedNever()
                    .HasColumnName("sParameterId");

                entity.Property(e => e.BStatus).HasColumnName("bStatus");

                entity.Property(e => e.BVisible).HasColumnName("bVisible");

                entity.Property(e => e.SGroupId).HasColumnName("sGroupId");

                entity.Property(e => e.SOrder).HasColumnName("sOrder");

                entity.Property(e => e.VName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vName");

                entity.Property(e => e.VValue)
                    .IsUnicode(false)
                    .HasColumnName("vValue");
            });

            modelBuilder.Entity<SystemSection>(entity =>
            {
                entity.HasKey(e => e.SSectionId)
                    .HasName("PK_Configuration.SystemSection");

                entity.ToTable("SystemSection", "Configuration");

                entity.Property(e => e.SSectionId).HasColumnName("sSectionId");

                entity.Property(e => e.BStatus).HasColumnName("bStatus");

                entity.Property(e => e.BVisible).HasColumnName("bVisible");

                entity.Property(e => e.SOrder).HasColumnName("sOrder");

                entity.Property(e => e.SParentId).HasColumnName("sParentId");

                entity.Property(e => e.VName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("vName");
            });

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
