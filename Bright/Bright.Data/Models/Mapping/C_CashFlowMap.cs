using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class C_CashFlowMap : EntityTypeConfiguration<C_CashFlow>
    {
        public C_CashFlowMap()
        {
            // Primary Key
            this.HasKey(t => t.FlowId);

            // Properties
            this.Property(t => t.OrderCode)
                .HasMaxLength(50);

            this.Property(t => t.Remark)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("C_CashFlow");
            this.Property(t => t.FlowId).HasColumnName("FlowId");
            this.Property(t => t.Fk_UserId).HasColumnName("Fk_UserId");
            this.Property(t => t.Fk_AccountId).HasColumnName("Fk_AccountId");
            this.Property(t => t.FlowType).HasColumnName("FlowType");
            this.Property(t => t.InAmount).HasColumnName("InAmount");
            this.Property(t => t.OutAmount).HasColumnName("OutAmount");
            this.Property(t => t.FlowTime).HasColumnName("FlowTime");
            this.Property(t => t.OpUserId).HasColumnName("OpUserId");
            this.Property(t => t.OrderCode).HasColumnName("OrderCode");
            this.Property(t => t.CurrentBalance).HasColumnName("CurrentBalance");
            this.Property(t => t.PhaseId).HasColumnName("PhaseId");
            this.Property(t => t.Remark).HasColumnName("Remark");

            // Relationships
            this.HasRequired(t => t.C_AccountType)
                .WithMany(t => t.C_CashFlow)
                .HasForeignKey(d => d.Fk_AccountId);
            this.HasRequired(t => t.U_UserInfo)
                .WithMany(t => t.C_CashFlow)
                .HasForeignKey(d => d.Fk_UserId);

        }
    }
}
