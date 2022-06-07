using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class P_CategoryMap : EntityTypeConfiguration<P_Category>
    {
        public P_CategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.CategoryId);

            // Properties
            this.Property(t => t.CategoryName)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("P_Category");
            this.Property(t => t.CategoryId).HasColumnName("CategoryId");
            this.Property(t => t.CategoryParentId).HasColumnName("CategoryParentId");
            this.Property(t => t.CategoryName).HasColumnName("CategoryName");
            this.Property(t => t.CategorySeq).HasColumnName("CategorySeq");
            this.Property(t => t.IsShow).HasColumnName("IsShow");
        }
    }
}
