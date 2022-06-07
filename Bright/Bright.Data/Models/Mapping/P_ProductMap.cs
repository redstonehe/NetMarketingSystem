using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class P_ProductMap : EntityTypeConfiguration<P_Product>
    {
        public P_ProductMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductId);

            // Properties
            this.Property(t => t.ProductName)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.ProductCode)
                .HasMaxLength(50);

            this.Property(t => t.ProductBarcode)
                .HasMaxLength(50);

            this.Property(t => t.ProductDescription)
                .HasMaxLength(1500);

            this.Property(t => t.ProductImg)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("P_Product");
            this.Property(t => t.ProductId).HasColumnName("ProductId");
            this.Property(t => t.Fk_CategoryId).HasColumnName("Fk_CategoryId");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.ProductCode).HasColumnName("ProductCode");
            this.Property(t => t.ProductBarcode).HasColumnName("ProductBarcode");
            this.Property(t => t.ProductWeight).HasColumnName("ProductWeight");
            this.Property(t => t.ProductCost).HasColumnName("ProductCost");
            this.Property(t => t.ProductDescription).HasColumnName("ProductDescription");
            this.Property(t => t.ProductContent).HasColumnName("ProductContent");
            this.Property(t => t.ProductImg).HasColumnName("ProductImg");
            this.Property(t => t.IsPackage).HasColumnName("IsPackage");
            this.Property(t => t.IsSale).HasColumnName("IsSale");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");

            // Relationships
            this.HasRequired(t => t.P_Category)
                .WithMany(t => t.P_Product)
                .HasForeignKey(d => d.Fk_CategoryId);

        }
    }
}
