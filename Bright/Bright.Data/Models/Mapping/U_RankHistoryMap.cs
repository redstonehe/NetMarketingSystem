using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class U_RankHistoryMap : EntityTypeConfiguration<U_RankHistory>
    {
        public U_RankHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.HistoryId);

            // Properties
            this.Property(t => t.Remark)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("U_RankHistory");
            this.Property(t => t.HistoryId).HasColumnName("HistoryId");
            this.Property(t => t.Fk_UserId).HasColumnName("Fk_UserId");
            this.Property(t => t.Fk_RankId).HasColumnName("Fk_RankId");
            this.Property(t => t.ChangeTime).HasColumnName("ChangeTime");
            this.Property(t => t.Remark).HasColumnName("Remark");

            // Relationships
            this.HasRequired(t => t.U_Rank)
                .WithMany(t => t.U_RankHistory)
                .HasForeignKey(d => d.Fk_RankId);
            this.HasRequired(t => t.U_UserInfo)
                .WithMany(t => t.U_RankHistory)
                .HasForeignKey(d => d.Fk_UserId);

        }
    }
}
