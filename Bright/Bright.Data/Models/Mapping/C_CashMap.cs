using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class C_CashMap : EntityTypeConfiguration<C_Cash>
    {
        public C_CashMap()
        {
            // Primary Key
            this.HasKey(t => t.CashId);

            // Properties
            this.Property(t => t.OrderCode)
                .HasMaxLength(50);

            this.Property(t => t.BankUserName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BankName)
                .HasMaxLength(50);

            this.Property(t => t.BankCode)
                .HasMaxLength(50);

            this.Property(t => t.BankProvince)
                .HasMaxLength(50);

            this.Property(t => t.BankCity)
                .HasMaxLength(50);

            this.Property(t => t.BankArea)
                .HasMaxLength(50);

            this.Property(t => t.BankAddress)
                .HasMaxLength(150);

            this.Property(t => t.Remark)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("C_Cash");
            this.Property(t => t.CashId).HasColumnName("CashId");
            this.Property(t => t.Fk_UserId).HasColumnName("Fk_UserId");
            this.Property(t => t.Fk_AccountId).HasColumnName("Fk_AccountId");
            this.Property(t => t.OrderCode).HasColumnName("OrderCode");
            this.Property(t => t.OpUserId).HasColumnName("OpUserId");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.Costs).HasColumnName("Costs");
            this.Property(t => t.ActualAmount).HasColumnName("ActualAmount");
            this.Property(t => t.ActualExChangeAmount).HasColumnName("ActualExChangeAmount");
            this.Property(t => t.Fk_CurrencyId).HasColumnName("Fk_CurrencyId");
            this.Property(t => t.BankUserName).HasColumnName("BankUserName");
            this.Property(t => t.BankName).HasColumnName("BankName");
            this.Property(t => t.BankCode).HasColumnName("BankCode");
            this.Property(t => t.BankProvince).HasColumnName("BankProvince");
            this.Property(t => t.BankCity).HasColumnName("BankCity");
            this.Property(t => t.BankArea).HasColumnName("BankArea");
            this.Property(t => t.BankAddress).HasColumnName("BankAddress");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.PayTime).HasColumnName("PayTime");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.PhaseId).HasColumnName("PhaseId");
            this.Property(t => t.Remark).HasColumnName("Remark");

            // Relationships
            this.HasRequired(t => t.C_AccountType)
                .WithMany(t => t.C_Cash)
                .HasForeignKey(d => d.Fk_AccountId);
            this.HasRequired(t => t.U_UserInfo)
                .WithMany(t => t.C_Cash)
                .HasForeignKey(d => d.Fk_UserId);

        }
    }
}
