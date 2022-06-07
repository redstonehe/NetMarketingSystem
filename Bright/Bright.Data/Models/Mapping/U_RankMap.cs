using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class U_RankMap : EntityTypeConfiguration<U_Rank>
    {
        public U_RankMap()
        {
            // Primary Key
            this.HasKey(t => t.RankId);

            // Properties
            this.Property(t => t.RankId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RankName)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("U_Rank");
            this.Property(t => t.RankId).HasColumnName("RankId");
            this.Property(t => t.RankName).HasColumnName("RankName");
            this.Property(t => t.RankMoney).HasColumnName("RankMoney");
            this.Property(t => t.RankPv).HasColumnName("RankPv");
            this.Property(t => t.Fk_TitleId).HasColumnName("Fk_TitleId");
            this.Property(t => t.RecommendPercent).HasColumnName("RecommendPercent");
            this.Property(t => t.IsCreatStation).HasColumnName("IsCreatStation");
            this.Property(t => t.StationRankId).HasColumnName("StationRankId");

            // Relationships
            this.HasRequired(t => t.U_AwardTitle)
                .WithMany(t => t.U_Rank)
                .HasForeignKey(d => d.Fk_TitleId);

        }
    }
}
