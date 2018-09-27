using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace OrderManagementApplication.Models
{
    public partial class OrderManagementContext : DbContext
    {
        public OrderManagementContext()
        {
        }

        public OrderManagementContext(DbContextOptions<OrderManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ClientMaster> ClientMaster { get; set; }
        public virtual DbSet<ItemMaster> ItemMaster { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=DESKTOP-D6FS7LS;Database=OrderManagement;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClientMaster>(entity =>
            {
                entity.HasKey(e => e.ClientId)
                    .HasName("PK__ClientMa__E67E1A04B21F9F63");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.Address)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ClientMaster)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK__ClientMas__ItemI__3B75D760");
            });

            modelBuilder.Entity<ItemMaster>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__ItemMast__727E83EB91DEB420");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.ItemCategory)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });
        }
    }
}
