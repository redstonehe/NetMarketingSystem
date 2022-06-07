using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class C_CurrencyMap : EntityTypeConfiguration<C_Currency>
    {
        public C_CurrencyMap()
        {
            // Primary Key
            this.HasKey(t => t.CurrencyId);

            // Properties
            this.Property(t => t.CurrencyId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CurrencyName)
                .HasMaxLength(50);

            this.Property(t => t.Sign)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("C_Currency");
            this.Property(t => t.CurrencyId).HasColumnName("CurrencyId");
            this.Property(t => t.CurrencyName).HasColumnName("CurrencyName");
            this.Property(t => t.Sign).HasColumnName("Sign");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.IsCosts).HasColumnName("IsCosts");
        }
    }
}
