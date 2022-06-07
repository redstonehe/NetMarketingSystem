using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class C_AccountMap : EntityTypeConfiguration<C_Account>
    {
        public C_AccountMap()
        {
            // Primary Key
            this.HasKey(t => t.AccId);

            // Properties
            // Table & Column Mappings
            this.ToTable("C_Account");
            this.Property(t => t.AccId).HasColumnName("AccId");
            this.Property(t => t.Fk_AccountId).HasColumnName("Fk_AccountId");
            this.Property(t => t.Fk_UserId).HasColumnName("Fk_UserId");
            this.Property(t => t.TotalIn).HasColumnName("TotalIn");
            this.Property(t => t.TotalOut).HasColumnName("TotalOut");
            this.Property(t => t.Balance).HasColumnName("Balance");
            this.Property(t => t.LockBalance).HasColumnName("LockBalance");

            // Relationships
            this.HasRequired(t => t.C_AccountType)
                .WithMany(t => t.C_Account)
                .HasForeignKey(d => d.Fk_AccountId);
            this.HasRequired(t => t.U_UserInfo)
                .WithMany(t => t.C_Account)
                .HasForeignKey(d => d.Fk_UserId);

        }
    }
}
