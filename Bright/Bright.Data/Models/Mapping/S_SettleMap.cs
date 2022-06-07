using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class S_SettleMap : EntityTypeConfiguration<S_Settle>
    {
        public S_SettleMap()
        {
            // Primary Key
            this.HasKey(t => t.SettleId);

            // Properties
            // Table & Column Mappings
            this.ToTable("S_Settle");
            this.Property(t => t.SettleId).HasColumnName("SettleId");
            this.Property(t => t.Fk_UserId).HasColumnName("Fk_UserId");
            this.Property(t => t.PhaseId).HasColumnName("PhaseId");
            this.Property(t => t.Area).HasColumnName("Area");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.LimitAmount).HasColumnName("LimitAmount");
            this.Property(t => t.LeftAmount).HasColumnName("LeftAmount");
        }
    }
}
