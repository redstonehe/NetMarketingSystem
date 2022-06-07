using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class S_ScoreMap : EntityTypeConfiguration<S_Score>
    {
        public S_ScoreMap()
        {
            // Primary Key
            this.HasKey(t => t.ScoreId);

            // Properties
            this.Property(t => t.OrderCode)
                .HasMaxLength(50);

            this.Property(t => t.Remark)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("S_Score");
            this.Property(t => t.ScoreId).HasColumnName("ScoreId");
            this.Property(t => t.Fk_UserId).HasColumnName("Fk_UserId");
            this.Property(t => t.OrderUserId).HasColumnName("OrderUserId");
            this.Property(t => t.OrderCode).HasColumnName("OrderCode");
            this.Property(t => t.Area).HasColumnName("Area");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.PhaseId).HasColumnName("PhaseId");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.Remark).HasColumnName("Remark");
            this.Property(t => t.IsOld).HasColumnName("IsOld");

            // Relationships
            this.HasRequired(t => t.U_UserInfo)
                .WithMany(t => t.S_Score)
                .HasForeignKey(d => d.Fk_UserId);

        }
    }
}
