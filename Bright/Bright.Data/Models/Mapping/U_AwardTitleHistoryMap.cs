using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class U_AwardTitleHistoryMap : EntityTypeConfiguration<U_AwardTitleHistory>
    {
        public U_AwardTitleHistoryMap()
        {
            // Primary Key
            this.HasKey(t => t.HistoryId);

            // Properties
            this.Property(t => t.Remark)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("U_AwardTitleHistory");
            this.Property(t => t.HistoryId).HasColumnName("HistoryId");
            this.Property(t => t.Fk_UserId).HasColumnName("Fk_UserId");
            this.Property(t => t.Fk_TitleId).HasColumnName("Fk_TitleId");
            this.Property(t => t.ChangeTime).HasColumnName("ChangeTime");
            this.Property(t => t.Remark).HasColumnName("Remark");

            // Relationships
            this.HasRequired(t => t.U_AwardTitle)
                .WithMany(t => t.U_AwardTitleHistory)
                .HasForeignKey(d => d.Fk_TitleId);
            this.HasRequired(t => t.U_UserInfo)
                .WithMany(t => t.U_AwardTitleHistory)
                .HasForeignKey(d => d.Fk_UserId);

        }
    }
}
