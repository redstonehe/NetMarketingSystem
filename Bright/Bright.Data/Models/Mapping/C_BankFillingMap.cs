using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class C_BankFillingMap : EntityTypeConfiguration<C_BankFilling>
    {
        public C_BankFillingMap()
        {
            // Primary Key
            this.HasKey(t => t.BackId);

            // Properties
            this.Property(t => t.Remark)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("C_BankFilling");
            this.Property(t => t.BackId).HasColumnName("BackId");
            this.Property(t => t.Fk_UserId).HasColumnName("Fk_UserId");
            this.Property(t => t.Ammount).HasColumnName("Ammount");
            this.Property(t => t.Ammounted).HasColumnName("Ammounted");
            this.Property(t => t.FillingPercent).HasColumnName("FillingPercent");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Remark).HasColumnName("Remark");

            // Relationships
            this.HasRequired(t => t.U_UserInfo)
                .WithMany(t => t.C_BankFilling)
                .HasForeignKey(d => d.Fk_UserId);

        }
    }
}
