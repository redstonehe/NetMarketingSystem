using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class U_RankSendMap : EntityTypeConfiguration<U_RankSend>
    {
        public U_RankSendMap()
        {
            // Primary Key
            this.HasKey(t => t.SendId);

            // Properties
            // Table & Column Mappings
            this.ToTable("U_RankSend");
            this.Property(t => t.SendId).HasColumnName("SendId");
            this.Property(t => t.Fk_RankId).HasColumnName("Fk_RankId");
            this.Property(t => t.Fk_AccountId).HasColumnName("Fk_AccountId");
            this.Property(t => t.Amount).HasColumnName("Amount");

            // Relationships
            this.HasRequired(t => t.U_Rank)
                .WithMany(t => t.U_RankSend)
                .HasForeignKey(d => d.Fk_RankId);

        }
    }
}
