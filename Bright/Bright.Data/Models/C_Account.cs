using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class C_Account
    {
        public System.Guid AccId { get; set; }
        public int Fk_AccountId { get; set; }
        public System.Guid Fk_UserId { get; set; }
        public decimal TotalIn { get; set; }
        public decimal TotalOut { get; set; }
        public decimal Balance { get; set; }
        public decimal LockBalance { get; set; }
        public virtual C_AccountType C_AccountType { get; set; }
        public virtual U_UserInfo U_UserInfo { get; set; }
    }
}
