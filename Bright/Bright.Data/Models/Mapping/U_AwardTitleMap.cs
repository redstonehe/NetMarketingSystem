using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class U_AwardTitleMap : EntityTypeConfiguration<U_AwardTitle>
    {
        public U_AwardTitleMap()
        {
            // Primary Key
            this.HasKey(t => t.TitleId);

            // Properties
            this.Property(t => t.TitleId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TitleName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("U_AwardTitle");
            this.Property(t => t.TitleId).HasColumnName("TitleId");
            this.Property(t => t.TitleName).HasColumnName("TitleName");
            this.Property(t => t.AreaCount).HasColumnName("AreaCount");
            this.Property(t => t.TotalScore).HasColumnName("TotalScore");
            this.Property(t => t.SmallScore).HasColumnName("SmallScore");
            this.Property(t => t.ChildRankId).HasColumnName("ChildRankId");
            this.Property(t => t.ChildRankCount).HasColumnName("ChildRankCount");
            this.Property(t => t.RankMod).HasColumnName("RankMod");
            this.Property(t => t.ChildTitleId).HasColumnName("ChildTitleId");
            this.Property(t => t.ChildTitleCount).HasColumnName("ChildTitleCount");
            this.Property(t => t.TitleMod).HasColumnName("TitleMod");
        }
    }
}
