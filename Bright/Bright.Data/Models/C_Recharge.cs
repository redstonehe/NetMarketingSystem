using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class C_Recharge
    {
        public System.Guid RechargeId { get; set; }
        public System.Guid Fk_UserId { get; set; }
        public int Fk_AccountId { get; set; }
        public decimal Amount { get; set; }
        public string OrderCode { get; set; }
        public string BankCode { get; set; }
        public string PayCode { get; set; }
        public System.DateTime CreateTime { get; set; }
        public Nullable<System.DateTime> PayTime { get; set; }
        public int Status { get; set; }
        public int PhaseId { get; set; }
        public string Remark { get; set; }
        public virtual C_AccountType C_AccountType { get; set; }
        public virtual U_UserInfo U_UserInfo { get; set; }
    }
}
