using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class P_PackageMap : EntityTypeConfiguration<P_Package>
    {
        public P_PackageMap()
        {
            // Primary Key
            this.HasKey(t => t.PackageId);

            // Properties
            // Table & Column Mappings
            this.ToTable("P_Package");
            this.Property(t => t.PackageId).HasColumnName("PackageId");
            this.Property(t => t.Fk_Productd).HasColumnName("Fk_Productd");
            this.Property(t => t.ChildProducttId).HasColumnName("ChildProducttId");
            this.Property(t => t.ProductCount).HasColumnName("ProductCount");

            // Relationships
            this.HasRequired(t => t.P_Product)
                .WithMany(t => t.P_Package)
                .HasForeignKey(d => d.Fk_Productd);
            this.HasRequired(t => t.P_Product1)
                .WithMany(t => t.P_Package1)
                .HasForeignKey(d => d.ChildProducttId);

        }
    }
}
