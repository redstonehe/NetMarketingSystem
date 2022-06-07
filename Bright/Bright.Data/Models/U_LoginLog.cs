using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class U_LoginLog
    {
        public System.Guid LogId { get; set; }
        public System.Guid Fk_UserId { get; set; }
        public int LoginType { get; set; }
        public System.DateTime LoginTime { get; set; }
        public string LoginIP { get; set; }
        public string LoginSessionId { get; set; }
        public Nullable<System.DateTime> LoginOutTime { get; set; }
        public int Status { get; set; }
        public virtual U_UserInfo U_UserInfo { get; set; }
    }
}
