using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class U_UserInfo
    {
        public U_UserInfo()
        {
            this.C_Account = new List<C_Account>();
            this.C_BankFilling = new List<C_BankFilling>();
            this.C_Cash = new List<C_Cash>();
            this.C_CashFlow = new List<C_CashFlow>();
            this.C_Recharge = new List<C_Recharge>();
            this.C_Transfer = new List<C_Transfer>();
            this.C_Transfer1 = new List<C_Transfer>();
            this.S_Score = new List<S_Score>();
            this.U_Address = new List<U_Address>();
            this.U_AwardTitleHistory = new List<U_AwardTitleHistory>();
            this.U_Bank = new List<U_Bank>();
            this.U_LoginLog = new List<U_LoginLog>();
            this.U_ManagerRelation = new List<U_ManagerRelation>();
            this.U_ManagerRelation1 = new List<U_ManagerRelation>();
            this.U_ParentRelation = new List<U_ParentRelation>();
            this.U_ParentRelation1 = new List<U_ParentRelation>();
            this.U_Password = new List<U_Password>();
            this.U_RankHistory = new List<U_RankHistory>();
            this.U_UserInfo1 = new List<U_UserInfo>();
        }

        public System.Guid UserId { get; set; }
        public string BusinessCode { get; set; }
        public string MallCode { get; set; }
        public Nullable<System.Guid> ParentUserId { get; set; }
        public int ParentArea { get; set; }
        public Nullable<System.Guid> ManagerUserId { get; set; }
        public int ManagerArea { get; set; }
        public string UserName { get; set; }
        public string NickName { get; set; }
        public Nullable<int> Fk_TeamId { get; set; }
        public Nullable<int> Fk_ActiveRankId { get; set; }
        public Nullable<int> Fk_RankId { get; set; }
        public Nullable<int> Fk_ActiveTitleId { get; set; }
        public Nullable<int> Fk_TitleId { get; set; }
        public System.DateTime RegisterTime { get; set; }
        public string RegisterIP { get; set; }
        public Nullable<System.DateTime> ActiveTime { get; set; }
        public Nullable<System.DateTime> UpgradeTime { get; set; }
        public int UserSex { get; set; }
        public string UserPhone { get; set; }
        public bool IsPhoneBind { get; set; }
        public string UserTel { get; set; }
        public string UserCard { get; set; }
        public string UserEmail { get; set; }
        public string UserQQ { get; set; }
        public string UserCountry { get; set; }
        public string UserProvince { get; set; }
        public string UserCity { get; set; }
        public string UserArea { get; set; }
        public string UserAddress { get; set; }
        public string UserPost { get; set; }
        public int RegistPhaseId { get; set; }
        public int ActivePhaseId { get; set; }
        public bool IsStation { get; set; }
        public Nullable<int> Fk_StationId { get; set; }
        public Nullable<System.Guid> RegistUserId { get; set; }
        public Nullable<System.Guid> ActiveUserId { get; set; }
        public bool IsVip { get; set; }
        public bool IsCompany { get; set; }
        public bool IsEmpty { get; set; }
        public int ExpirePhaseId { get; set; }
        public int BindStatus { get; set; }
        public bool IsLockAward { get; set; }
        public bool IsLockTransfer { get; set; }
        public bool IsLockCash { get; set; }
        public bool IsQualified { get; set; }
        public int Status { get; set; }
        public string Remark { get; set; }
        public virtual ICollection<C_Account> C_Account { get; set; }
        public virtual ICollection<C_BankFilling> C_BankFilling { get; set; }
        public virtual ICollection<C_Cash> C_Cash { get; set; }
        public virtual ICollection<C_CashFlow> C_CashFlow { get; set; }
        public virtual ICollection<C_Recharge> C_Recharge { get; set; }
        public virtual ICollection<C_Transfer> C_Transfer { get; set; }
        public virtual ICollection<C_Transfer> C_Transfer1 { get; set; }
        public virtual ICollection<S_Score> S_Score { get; set; }
        public virtual S_Track2 S_Track2 { get; set; }
        public virtual ICollection<U_Address> U_Address { get; set; }
        public virtual ICollection<U_AwardTitleHistory> U_AwardTitleHistory { get; set; }
        public virtual ICollection<U_Bank> U_Bank { get; set; }
        public virtual ICollection<U_LoginLog> U_LoginLog { get; set; }
        public virtual ICollection<U_ManagerRelation> U_ManagerRelation { get; set; }
        public virtual ICollection<U_ManagerRelation> U_ManagerRelation1 { get; set; }
        public virtual ICollection<U_ParentRelation> U_ParentRelation { get; set; }
        public virtual ICollection<U_ParentRelation> U_ParentRelation1 { get; set; }
        public virtual ICollection<U_Password> U_Password { get; set; }
        public virtual ICollection<U_RankHistory> U_RankHistory { get; set; }
        public virtual ICollection<U_UserInfo> U_UserInfo1 { get; set; }
        public virtual U_UserInfo U_UserInfo2 { get; set; }
    }
}
