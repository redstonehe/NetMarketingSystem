using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class U_TeamMap : EntityTypeConfiguration<U_Team>
    {
        public U_TeamMap()
        {
            // Primary Key
            this.HasKey(t => t.TeamId);

            // Properties
            this.Property(t => t.TeamId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TeamName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("U_Team");
            this.Property(t => t.TeamId).HasColumnName("TeamId");
            this.Property(t => t.TeamName).HasColumnName("TeamName");
        }
    }
}
