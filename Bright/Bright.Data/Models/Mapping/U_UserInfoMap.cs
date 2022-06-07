using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Bright.Data.Models.Mapping
{
    public class U_UserInfoMap : EntityTypeConfiguration<U_UserInfo>
    {
        public U_UserInfoMap()
        {
            // Primary Key
            this.HasKey(t => t.UserId);

            // Properties
            this.Property(t => t.BusinessCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MallCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UserName)
                .HasMaxLength(50);

            this.Property(t => t.NickName)
                .HasMaxLength(50);

            this.Property(t => t.RegisterIP)
                .HasMaxLength(50);

            this.Property(t => t.UserPhone)
                .HasMaxLength(50);

            this.Property(t => t.UserTel)
                .HasMaxLength(50);

            this.Property(t => t.UserCard)
                .HasMaxLength(50);

            this.Property(t => t.UserEmail)
                .HasMaxLength(50);

            this.Property(t => t.UserQQ)
                .HasMaxLength(50);

            this.Property(t => t.UserCountry)
                .HasMaxLength(50);

            this.Property(t => t.UserProvince)
                .HasMaxLength(50);

            this.Property(t => t.UserCity)
                .HasMaxLength(50);

            this.Property(t => t.UserArea)
                .HasMaxLength(50);

            this.Property(t => t.UserAddress)
                .HasMaxLength(150);

            this.Property(t => t.UserPost)
                .HasMaxLength(50);

            this.Property(t => t.Remark)
                .HasMaxLength(150);

            // Table & Column Mappings
            this.ToTable("U_UserInfo");
            this.Property(t => t.UserId).HasColumnName("UserId");
            this.Property(t => t.BusinessCode).HasColumnName("BusinessCode");
            this.Property(t => t.MallCode).HasColumnName("MallCode");
            this.Property(t => t.ParentUserId).HasColumnName("ParentUserId");
            this.Property(t => t.ParentArea).HasColumnName("ParentArea");
            this.Property(t => t.ManagerUserId).HasColumnName("ManagerUserId");
            this.Property(t => t.ManagerArea).HasColumnName("ManagerArea");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.NickName).HasColumnName("NickName");
            this.Property(t => t.Fk_TeamId).HasColumnName("Fk_TeamId");
            this.Property(t => t.Fk_ActiveRankId).HasColumnName("Fk_ActiveRankId");
            this.Property(t => t.Fk_RankId).HasColumnName("Fk_RankId");
            this.Property(t => t.Fk_ActiveTitleId).HasColumnName("Fk_ActiveTitleId");
            this.Property(t => t.Fk_TitleId).HasColumnName("Fk_TitleId");
            this.Property(t => t.RegisterTime).HasColumnName("RegisterTime");
            this.Property(t => t.RegisterIP).HasColumnName("RegisterIP");
            this.Property(t => t.ActiveTime).HasColumnName("ActiveTime");
            this.Property(t => t.UpgradeTime).HasColumnName("UpgradeTime");
            this.Property(t => t.UserSex).HasColumnName("UserSex");
            this.Property(t => t.UserPhone).HasColumnName("UserPhone");
            this.Property(t => t.IsPhoneBind).HasColumnName("IsPhoneBind");
            this.Property(t => t.UserTel).HasColumnName("UserTel");
            this.Property(t => t.UserCard).HasColumnName("UserCard");
            this.Property(t => t.UserEmail).HasColumnName("UserEmail");
            this.Property(t => t.UserQQ).HasColumnName("UserQQ");
            this.Property(t => t.UserCountry).HasColumnName("UserCountry");
            this.Property(t => t.UserProvince).HasColumnName("UserProvince");
            this.Property(t => t.UserCity).HasColumnName("UserCity");
            this.Property(t => t.UserArea).HasColumnName("UserArea");
            this.Property(t => t.UserAddress).HasColumnName("UserAddress");
            this.Property(t => t.UserPost).HasColumnName("UserPost");
            this.Property(t => t.RegistPhaseId).HasColumnName("RegistPhaseId");
            this.Property(t => t.ActivePhaseId).HasColumnName("ActivePhaseId");
            this.Property(t => t.IsStation).HasColumnName("IsStation");
            this.Property(t => t.Fk_StationId).HasColumnName("Fk_StationId");
            this.Property(t => t.RegistUserId).HasColumnName("RegistUserId");
            this.Property(t => t.ActiveUserId).HasColumnName("ActiveUserId");
            this.Property(t => t.IsVip).HasColumnName("IsVip");
            this.Property(t => t.IsCompany).HasColumnName("IsCompany");
            this.Property(t => t.IsEmpty).HasColumnName("IsEmpty");
            this.Property(t => t.ExpirePhaseId).HasColumnName("ExpirePhaseId");
            this.Property(t => t.BindStatus).HasColumnName("BindStatus");
            this.Property(t => t.IsLockAward).HasColumnName("IsLockAward");
            this.Property(t => t.IsLockTransfer).HasColumnName("IsLockTransfer");
            this.Property(t => t.IsLockCash).HasColumnName("IsLockCash");
            this.Property(t => t.IsQualified).HasColumnName("IsQualified");
            this.Property(t => t.Status).HasColumnName("Status");
            this.Property(t => t.Remark).HasColumnName("Remark");

            // Relationships
            this.HasOptional(t => t.U_UserInfo2)
                .WithMany(t => t.U_UserInfo1)
                .HasForeignKey(d => d.ParentUserId);

        }
    }
}
