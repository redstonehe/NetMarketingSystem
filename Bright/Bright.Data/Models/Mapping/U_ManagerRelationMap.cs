using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class U_ManagerRelationMap : EntityTypeConfiguration<U_ManagerRelation>
    {
        public U_ManagerRelationMap()
        {
            // Primary Key
            this.HasKey(t => t.RelationId);

            // Properties
            // Table & Column Mappings
            this.ToTable("U_ManagerRelation");
            this.Property(t => t.RelationId).HasColumnName("RelationId");
            this.Property(t => t.Fk_UserId).HasColumnName("Fk_UserId");
            this.Property(t => t.Fk_ManagerUserId).HasColumnName("Fk_ManagerUserId");
            this.Property(t => t.Area).HasColumnName("Area");
            this.Property(t => t.Depth).HasColumnName("Depth");

            // Relationships
            this.HasRequired(t => t.U_UserInfo)
                .WithMany(t => t.U_ManagerRelation)
                .HasForeignKey(d => d.Fk_UserId);
            this.HasRequired(t => t.U_UserInfo1)
                .WithMany(t => t.U_ManagerRelation1)
                .HasForeignKey(d => d.Fk_ManagerUserId);

        }
    }
}
