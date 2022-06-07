using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class P_PriceMap : EntityTypeConfiguration<P_Price>
    {
        public P_PriceMap()
        {
            // Primary Key
            this.HasKey(t => t.PriceId);

            // Properties
            // Table & Column Mappings
            this.ToTable("P_Price");
            this.Property(t => t.PriceId).HasColumnName("PriceId");
            this.Property(t => t.Fk_TypeId).HasColumnName("Fk_TypeId");
            this.Property(t => t.Fk_ProductId).HasColumnName("Fk_ProductId");
            this.Property(t => t.MarketPrice).HasColumnName("MarketPrice");
            this.Property(t => t.MallPrice).HasColumnName("MallPrice");
            this.Property(t => t.ProductPv).HasColumnName("ProductPv");
            this.Property(t => t.IsPromotion).HasColumnName("IsPromotion");
            this.Property(t => t.PromotionPrice).HasColumnName("PromotionPrice");
            this.Property(t => t.PromotionPv).HasColumnName("PromotionPv");

            // Relationships
            this.HasRequired(t => t.O_Type)
                .WithMany(t => t.P_Price)
                .HasForeignKey(d => d.Fk_TypeId);
            this.HasRequired(t => t.P_Product)
                .WithMany(t => t.P_Price)
                .HasForeignKey(d => d.Fk_ProductId);

        }
    }
}
