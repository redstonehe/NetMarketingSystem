using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class S_Track2Map : EntityTypeConfiguration<S_Track2>
    {
        public S_Track2Map()
        {
            // Primary Key
            this.HasKey(t => t.UserId);

            // Properties
            // Table & Column Mappings
            this.ToTable("S_Track2");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.Area1).HasColumnName("Area1");
            this.Property(t => t.Area1NewAdd).HasColumnName("Area1NewAdd");
            this.Property(t => t.Area1Settle).HasColumnName("Area1Settle");
            this.Property(t => t.Area1Count).HasColumnName("Area1Count");
            this.Property(t => t.Area2).HasColumnName("Area2");
            this.Property(t => t.Area2NewAdd).HasColumnName("Area2NewAdd");
            this.Property(t => t.Area2Settle).HasColumnName("Area2Settle");
            this.Property(t => t.Area2Count).HasColumnName("Area2Count");

            // Relationships
            this.HasRequired(t => t.U_UserInfo)
                .WithOptional(t => t.S_Track2);

        }
    }
}
