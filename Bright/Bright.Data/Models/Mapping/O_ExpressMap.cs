using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class O_ExpressMap : EntityTypeConfiguration<O_Express>
    {
        public O_ExpressMap()
        {
            // Primary Key
            this.HasKey(t => t.ExpressId);

            // Properties
            this.Property(t => t.ExpressName)
                .HasMaxLength(50);

            this.Property(t => t.ExpressTel)
                .HasMaxLength(150);

            this.Property(t => t.ExpressUrl)
                .HasMaxLength(150);

            this.Property(t => t.Remark)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("O_Express");
            this.Property(t => t.ExpressId).HasColumnName("ExpressId");
            this.Property(t => t.ExpressName).HasColumnName("ExpressName");
            this.Property(t => t.ExpressTel).HasColumnName("ExpressTel");
            this.Property(t => t.ExpressUrl).HasColumnName("ExpressUrl");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.IsDefault).HasColumnName("IsDefault");
        }
    }
}
