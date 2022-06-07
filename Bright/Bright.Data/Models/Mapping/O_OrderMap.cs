using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class O_OrderMap : EntityTypeConfiguration<O_Order>
    {
        public O_OrderMap()
        {
            // Primary Key
            this.HasKey(t => t.OrderId);

            // Properties
            this.Property(t => t.OrderCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ReceiveUserName)
                .HasMaxLength(50);

            this.Property(t => t.Tel)
                .HasMaxLength(50);

            this.Property(t => t.Phone)
                .HasMaxLength(50);

            this.Property(t => t.Province)
                .HasMaxLength(50);

            this.Property(t => t.City)
                .HasMaxLength(50);

            this.Property(t => t.Area)
                .HasMaxLength(50);

            this.Property(t => t.Address)
                .HasMaxLength(150);

            this.Property(t => t.InvoiceType)
                .HasMaxLength(50);

            this.Property(t => t.InvoiceTitle)
                .HasMaxLength(50);

            this.Property(t => t.InvoiceContent)
                .HasMaxLength(150);

            this.Property(t => t.InvoiceCompany)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("O_Order");
            this.Property(t => t.OrderId).HasColumnName("OrderId");
            this.Property(t => t.OrderCode).HasColumnName("OrderCode");
            this.Property(t => t.Fk_ExpressId).HasColumnName("Fk_ExpressId");
            this.Property(t => t.ReceiveUserName).HasColumnName("ReceiveUserName");
            this.Property(t => t.Tel).HasColumnName("Tel");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Province).HasColumnName("Province");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Area).HasColumnName("Area");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.ExpressMoney).HasColumnName("ExpressMoney");
            this.Property(t => t.ExpressStatus).HasColumnName("ExpressStatus");
            this.Property(t => t.ReceiveTime).HasColumnName("ReceiveTime");
            this.Property(t => t.IsInvoice).HasColumnName("IsInvoice");
            this.Property(t => t.InvoiceType).HasColumnName("InvoiceType");
            this.Property(t => t.InvoiceTitle).HasColumnName("InvoiceTitle");
            this.Property(t => t.InvoiceContent).HasColumnName("InvoiceContent");
            this.Property(t => t.InvoiceCompany).HasColumnName("InvoiceCompany");

            // Relationships
            this.HasRequired(t => t.O_Common)
                .WithOptional(t => t.O_Order);
            this.HasRequired(t => t.O_Express)
                .WithMany(t => t.O_Order)
                .HasForeignKey(d => d.Fk_ExpressId);

        }
    }
}
