using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class C_TransferMap : EntityTypeConfiguration<C_Transfer>
    {
        public C_TransferMap()
        {
            // Primary Key
            this.HasKey(t => t.TransferId);

            // Properties
            this.Property(t => t.OrderCode)
                .HasMaxLength(50);

            this.Property(t => t.Remark)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("C_Transfer");
            this.Property(t => t.TransferId).HasColumnName("TransferId");
            this.Property(t => t.OrderCode).HasColumnName("OrderCode");
            this.Property(t => t.Fk_UserId).HasColumnName("Fk_UserId");
            this.Property(t => t.Fk_AccountId).HasColumnName("Fk_AccountId");
            this.Property(t => t.Fk_ToUserId).HasColumnName("Fk_ToUserId");
            this.Property(t => t.Fk_ToAccountId).HasColumnName("Fk_ToAccountId");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.Costs).HasColumnName("Costs");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.PhaseId).HasColumnName("PhaseId");
            this.Property(t => t.Remark).HasColumnName("Remark");

            // Relationships
            this.HasRequired(t => t.C_AccountType)
                .WithMany(t => t.C_Transfer)
                .HasForeignKey(d => d.Fk_AccountId);
            this.HasRequired(t => t.C_AccountType1)
                .WithMany(t => t.C_Transfer1)
                .HasForeignKey(d => d.Fk_ToAccountId);
            this.HasRequired(t => t.U_UserInfo)
                .WithMany(t => t.C_Transfer)
                .HasForeignKey(d => d.Fk_UserId);
            this.HasRequired(t => t.U_UserInfo1)
                .WithMany(t => t.C_Transfer1)
                .HasForeignKey(d => d.Fk_ToUserId);

        }
    }
}
