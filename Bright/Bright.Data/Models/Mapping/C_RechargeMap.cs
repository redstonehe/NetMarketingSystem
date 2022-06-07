using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class C_RechargeMap : EntityTypeConfiguration<C_Recharge>
    {
        public C_RechargeMap()
        {
            // Primary Key
            this.HasKey(t => t.RechargeId);

            // Properties
            this.Property(t => t.OrderCode)
                .HasMaxLength(50);

            this.Property(t => t.BankCode)
                .HasMaxLength(50);

            this.Property(t => t.PayCode)
                .HasMaxLength(50);

            this.Property(t => t.Remark)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("C_Recharge");
            this.Property(t => t.RechargeId).HasColumnName("RechargeId");
            this.Property(t => t.Fk_UserId).HasColumnName("Fk_UserId");
            this.Property(t => t.Fk_AccountId).HasColumnName("Fk_AccountId");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.OrderCode).HasColumnName("OrderCode");
            this.Property(t => t.BankCode).HasColumnName("BankCode");
            this.Property(t => t.PayCode).HasColumnName("PayCode");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.PayTime).HasColumnName("PayTime");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.PhaseId).HasColumnName("PhaseId");
            this.Property(t => t.Remark).HasColumnName("Remark");

            // Relationships
            this.HasRequired(t => t.C_AccountType)
                .WithMany(t => t.C_Recharge)
                .HasForeignKey(d => d.Fk_AccountId);
            this.HasRequired(t => t.U_UserInfo)
                .WithMany(t => t.C_Recharge)
                .HasForeignKey(d => d.Fk_UserId);

        }
    }
}
