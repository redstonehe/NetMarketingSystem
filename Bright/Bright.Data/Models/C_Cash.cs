using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class C_Cash
    {
        public System.Guid CashId { get; set; }
        public System.Guid Fk_UserId { get; set; }
        public int Fk_AccountId { get; set; }
        public string OrderCode { get; set; }
        public Nullable<System.Guid> OpUserId { get; set; }
        public decimal Amount { get; set; }
        public decimal Costs { get; set; }
        public decimal ActualAmount { get; set; }
        public decimal ActualExChangeAmount { get; set; }
        public int Fk_CurrencyId { get; set; }
        public string BankUserName { get; set; }
        public string BankName { get; set; }
        public string BankCode { get; set; }
        public string BankProvince { get; set; }
        public string BankCity { get; set; }
        public string BankArea { get; set; }
        public string BankAddress { get; set; }
        public System.DateTime CreateTime { get; set; }
        public Nullable<System.DateTime> PayTime { get; set; }
        public int Status { get; set; }
        public int PhaseId { get; set; }
        public string Remark { get; set; }
        public virtual C_AccountType C_AccountType { get; set; }
        public virtual U_UserInfo U_UserInfo { get; set; }
    }
}
