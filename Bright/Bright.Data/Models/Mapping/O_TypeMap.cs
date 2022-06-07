using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class O_TypeMap : EntityTypeConfiguration<O_Type>
    {
        public O_TypeMap()
        {
            // Primary Key
            this.HasKey(t => t.TypeId);

            // Properties
            this.Property(t => t.TypeId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TypeName)
                .HasMaxLength(50);

            this.Property(t => t.OrderPrefix)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("O_Type");
            this.Property(t => t.TypeId).HasColumnName("TypeId");
            this.Property(t => t.TypeName).HasColumnName("TypeName");
            this.Property(t => t.OrderPrefix).HasColumnName("OrderPrefix");
            this.Property(t => t.IsScore).HasColumnName("IsScore");
            this.Property(t => t.IsRecommendAward).HasColumnName("IsRecommendAward");
            this.Property(t => t.IsStationAward).HasColumnName("IsStationAward");
            this.Property(t => t.IsDifferentialAward).HasColumnName("IsDifferentialAward");
        }
    }
}
