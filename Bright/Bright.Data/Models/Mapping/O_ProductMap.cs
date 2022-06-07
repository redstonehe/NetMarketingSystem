using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class O_ProductMap : EntityTypeConfiguration<O_Product>
    {
        public O_ProductMap()
        {
            // Primary Key
            this.HasKey(t => t.OrderProductId);

            // Properties
            this.Property(t => t.Remark)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("O_Product");
            this.Property(t => t.OrderProductId).HasColumnName("OrderProductId");
            this.Property(t => t.Fk_OrderId).HasColumnName("Fk_OrderId");
            this.Property(t => t.Fk_ProductId).HasColumnName("Fk_ProductId");
            this.Property(t => t.Fk_ParentId).HasColumnName("Fk_ParentId");
            this.Property(t => t.ProductCount).HasColumnName("ProductCount");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.Pv).HasColumnName("Pv");
            this.Property(t => t.IsPackage).HasColumnName("IsPackage");
            this.Property(t => t.Remark).HasColumnName("Remark");

            // Relationships
            this.HasRequired(t => t.O_Common)
                .WithMany(t => t.O_Product)
                .HasForeignKey(d => d.Fk_OrderId);
            this.HasOptional(t => t.O_Product2)
                .WithMany(t => t.O_Product1)
                .HasForeignKey(d => d.Fk_ParentId);
            this.HasRequired(t => t.P_Product)
                .WithMany(t => t.O_Product)
                .HasForeignKey(d => d.Fk_ProductId);
            this.HasOptional(t => t.P_Product1)
                .WithMany(t => t.O_Product1)
                .HasForeignKey(d => d.Fk_ParentId);

        }
    }
}
