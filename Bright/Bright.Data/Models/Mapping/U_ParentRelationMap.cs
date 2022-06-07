using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class U_ParentRelationMap : EntityTypeConfiguration<U_ParentRelation>
    {
        public U_ParentRelationMap()
        {
            // Primary Key
            this.HasKey(t => t.RelationId);

            // Properties
            // Table & Column Mappings
            this.ToTable("U_ParentRelation");
            this.Property(t => t.RelationId).HasColumnName("RelationId");
            this.Property(t => t.Fk_UserId).HasColumnName("Fk_UserId");
            this.Property(t => t.Fk_ParentUserId).HasColumnName("Fk_ParentUserId");
            this.Property(t => t.Area).HasColumnName("Area");
            this.Property(t => t.Depth).HasColumnName("Depth");

            // Relationships
            this.HasRequired(t => t.U_UserInfo)
                .WithMany(t => t.U_ParentRelation)
                .HasForeignKey(d => d.Fk_UserId);
            this.HasRequired(t => t.U_UserInfo1)
                .WithMany(t => t.U_ParentRelation1)
                .HasForeignKey(d => d.Fk_ParentUserId);

        }
    }
}
