using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class U_LoginLogMap : EntityTypeConfiguration<U_LoginLog>
    {
        public U_LoginLogMap()
        {
            // Primary Key
            this.HasKey(t => t.LogId);

            // Properties
            this.Property(t => t.LoginIP)
                .HasMaxLength(50);

            this.Property(t => t.LoginSessionId)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("U_LoginLog");
            this.Property(t => t.LogId).HasColumnName("LogId");
            this.Property(t => t.Fk_UserId).HasColumnName("Fk_UserId");
            this.Property(t => t.LoginType).HasColumnName("LoginType");
            this.Property(t => t.LoginTime).HasColumnName("LoginTime");
            this.Property(t => t.LoginIP).HasColumnName("LoginIP");
            this.Property(t => t.LoginSessionId).HasColumnName("LoginSessionId");
            this.Property(t => t.LoginOutTime).HasColumnName("LoginOutTime");
            this.Property(t => t.Status).HasColumnName("Status");

            // Relationships
            this.HasRequired(t => t.U_UserInfo)
                .WithMany(t => t.U_LoginLog)
                .HasForeignKey(d => d.Fk_UserId);

        }
    }
}
