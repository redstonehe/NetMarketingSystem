using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class U_AddressMap : EntityTypeConfiguration<U_Address>
    {
        public U_AddressMap()
        {
            // Primary Key
            this.HasKey(t => t.AddressId);

            // Properties
            this.Property(t => t.Province)
                .HasMaxLength(50);

            this.Property(t => t.City)
                .HasMaxLength(50);

            this.Property(t => t.Area)
                .HasMaxLength(50);

            this.Property(t => t.Address)
                .HasMaxLength(150);

            this.Property(t => t.Post)
                .HasMaxLength(50);

            this.Property(t => t.Receiver)
                .HasMaxLength(50);

            this.Property(t => t.Phone)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("U_Address");
            this.Property(t => t.AddressId).HasColumnName("AddressId");
            this.Property(t => t.Fk_UserId).HasColumnName("Fk_UserId");
            this.Property(t => t.Province).HasColumnName("Province");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Area).HasColumnName("Area");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.Post).HasColumnName("Post");
            this.Property(t => t.Receiver).HasColumnName("Receiver");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.IsDefault).HasColumnName("IsDefault");

            // Relationships
            this.HasRequired(t => t.U_UserInfo)
                .WithMany(t => t.U_Address)
                .HasForeignKey(d => d.Fk_UserId);

        }
    }
}
