using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class U_Password
    {
        public System.Guid PasswordId { get; set; }
        public System.Guid Fk_UserId { get; set; }
        public int PasswordType { get; set; }
        public string Password { get; set; }
        public int PasswordAttemptCount { get; set; }
        public bool IsLock { get; set; }
        public Nullable<System.DateTime> LastLoginTime { get; set; }
        public string LastLoginIP { get; set; }
        public int LoginCount { get; set; }
        public string Remark { get; set; }
        public virtual U_UserInfo U_UserInfo { get; set; }
    }
}
