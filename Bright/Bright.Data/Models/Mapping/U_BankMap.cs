using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class U_BankMap : EntityTypeConfiguration<U_Bank>
    {
        public U_BankMap()
        {
            // Primary Key
            this.HasKey(t => t.BankId);

            // Properties
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

            // Table & Column Mappings
            this.ToTable("U_Bank");
            this.Property(t => t.BankId).HasColumnName("BankId");
            this.Property(t => t.Fk_UserId).HasColumnName("Fk_UserId");
            this.Property(t => t.BankName).HasColumnName("BankName");
            this.Property(t => t.BankCode).HasColumnName("BankCode");
            this.Property(t => t.BankProvince).HasColumnName("BankProvince");
            this.Property(t => t.BankCity).HasColumnName("BankCity");
            this.Property(t => t.BankArea).HasColumnName("BankArea");
            this.Property(t => t.BankAddress).HasColumnName("BankAddress");
            this.Property(t => t.IsDefault).HasColumnName("IsDefault");

            // Relationships
            this.HasRequired(t => t.U_UserInfo)
                .WithMany(t => t.U_Bank)
                .HasForeignKey(d => d.Fk_UserId);

        }
    }
}
