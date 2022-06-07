using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class P_TeamProductMap : EntityTypeConfiguration<P_TeamProduct>
    {
        public P_TeamProductMap()
        {
            // Primary Key
            this.HasKey(t => t.TpId);

            // Properties
            // Table & Column Mappings
            this.ToTable("P_TeamProduct");
            this.Property(t => t.TpId).HasColumnName("TpId");
            this.Property(t => t.Fk_TeamId).HasColumnName("Fk_TeamId");
            this.Property(t => t.Fk_ProductId).HasColumnName("Fk_ProductId");

            // Relationships
            this.HasRequired(t => t.P_Product)
                .WithMany(t => t.P_TeamProduct)
                .HasForeignKey(d => d.Fk_ProductId);
            this.HasRequired(t => t.U_Team)
                .WithMany(t => t.P_TeamProduct)
                .HasForeignKey(d => d.Fk_TeamId);

        }
    }
}
