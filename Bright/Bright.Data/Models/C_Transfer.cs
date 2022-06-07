using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class C_Transfer
    {
        public System.Guid TransferId { get; set; }
        public string OrderCode { get; set; }
        public System.Guid Fk_UserId { get; set; }
        public int Fk_AccountId { get; set; }
        public System.Guid Fk_ToUserId { get; set; }
        public int Fk_ToAccountId { get; set; }
        public decimal Amount { get; set; }
        public decimal Costs { get; set; }
        public System.DateTime CreateTime { get; set; }
        public int PhaseId { get; set; }
        public string Remark { get; set; }
        public virtual C_AccountType C_AccountType { get; set; }
        public virtual C_AccountType C_AccountType1 { get; set; }
        public virtual U_UserInfo U_UserInfo { get; set; }
        public virtual U_UserInfo U_UserInfo1 { get; set; }
    }
}
