using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class O_CommonMap : EntityTypeConfiguration<O_Common>
    {
        public O_CommonMap()
        {
            // Primary Key
            this.HasKey(t => t.OrderId);

            // Properties
            this.Property(t => t.OrderCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Remark)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("O_Common");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.OrderCode).HasColumnName("OrderCode");
            this.Property(t => t.Fk_UserId).HasColumnName("Fk_UserId");
            this.Property(t => t.Fk_TypeId).HasColumnName("Fk_TypeId");
            this.Property(t => t.OrderMoney).HasColumnName("OrderMoney");
            this.Property(t => t.OrderPv).HasColumnName("OrderPv");
            this.Property(t => t.CreateTime).HasColumnName("CreateTime");
            this.Property(t => t.PayTime).HasColumnName("PayTime");
            this.Property(t => t.BackTime).HasColumnName("BackTime");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.OrderUserId).HasColumnName("OrderUserId");
            this.Property(t => t.ReceiveUserId).HasColumnName("ReceiveUserId");
            this.Property(t => t.PayUserId).HasColumnName("PayUserId");
            this.Property(t => t.Remark).HasColumnName("Remark");
        }
    }
}
