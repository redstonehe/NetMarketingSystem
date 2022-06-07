using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class U_PasswordMap : EntityTypeConfiguration<U_Password>
    {
        public U_PasswordMap()
        {
            // Primary Key
            this.HasKey(t => t.PasswordId);

            // Properties
            this.Property(t => t.Password)
                .HasMaxLength(50);

            this.Property(t => t.LastLoginIP)
                .HasMaxLength(50);

            this.Property(t => t.Remark)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("U_Password");
            this.Property(t => t.PasswordId).HasColumnName("PasswordId");
            this.Property(t => t.Fk_UserId).HasColumnName("Fk_UserId");
            this.Property(t => t.PasswordType).HasColumnName("PasswordType");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.PasswordAttemptCount).HasColumnName("PasswordAttemptCount");
            this.Property(t => t.IsLock).HasColumnName("IsLock");
            this.Property(t => t.LastLoginTime).HasColumnName("LastLoginTime");
            this.Property(t => t.LastLoginIP).HasColumnName("LastLoginIP");
            this.Property(t => t.LoginCount).HasColumnName("LoginCount");
            this.Property(t => t.Remark).HasColumnName("Remark");

            // Relationships
            this.HasRequired(t => t.U_UserInfo)
                .WithMany(t => t.U_Password)
                .HasForeignKey(d => d.Fk_UserId);

        }
    }
}
