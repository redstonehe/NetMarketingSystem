using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class C_CashFlow
    {
        public System.Guid FlowId { get; set; }
        public System.Guid Fk_UserId { get; set; }
        public int Fk_AccountId { get; set; }
        public int FlowType { get; set; }
        public decimal InAmount { get; set; }
        public decimal OutAmount { get; set; }
        public System.DateTime FlowTime { get; set; }
        public Nullable<System.Guid> OpUserId { get; set; }
        public string OrderCode { get; set; }
        public decimal CurrentBalance { get; set; }
        public int PhaseId { get; set; }
        public string Remark { get; set; }
        public virtual C_AccountType C_AccountType { get; set; }
        public virtual U_UserInfo U_UserInfo { get; set; }
    }
}
