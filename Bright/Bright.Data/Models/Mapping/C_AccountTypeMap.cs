using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class C_AccountTypeMap : EntityTypeConfiguration<C_AccountType>
    {
        public C_AccountTypeMap()
        {
            // Primary Key
            this.HasKey(t => t.AccountId);

            // Properties
            this.Property(t => t.AccountId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AccountName)
                .HasMaxLength(50);

            this.Property(t => t.InterAccountIds)
                .HasMaxLength(100);

            this.Property(t => t.OuterAccountIds)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("C_AccountType");
            this.Property(t => t.AccountId).HasColumnName("AccountId");
            this.Property(t => t.AccountName).HasColumnName("AccountName");
            this.Property(t => t.IsInterTransfer).HasColumnName("IsInterTransfer");
            this.Property(t => t.InterAccountIds).HasColumnName("InterAccountIds");
            this.Property(t => t.IsOuterTransfer).HasColumnName("IsOuterTransfer");
            this.Property(t => t.OuterAccountIds).HasColumnName("OuterAccountIds");
            this.Property(t => t.IsAble).HasColumnName("IsAble");
            this.Property(t => t.TransferMin).HasColumnName("TransferMin");
            this.Property(t => t.TransferMultiple).HasColumnName("TransferMultiple");
            this.Property(t => t.IsRecharge).HasColumnName("IsRecharge");
            this.Property(t => t.IsCash).HasColumnName("IsCash");
            this.Property(t => t.CashPercent).HasColumnName("CashPercent");
            this.Property(t => t.CashDayCount).HasColumnName("CashDayCount");
            this.Property(t => t.CashCost).HasColumnName("CashCost");
            this.Property(t => t.IsBackFilling).HasColumnName("IsBackFilling");
        }
    }
}
