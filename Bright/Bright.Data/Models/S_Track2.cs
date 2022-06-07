using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class S_Track2
    {
        public System.Guid UserId { get; set; }
        public decimal Area1 { get; set; }
        public decimal Area1NewAdd { get; set; }
        public decimal Area1Settle { get; set; }
        public decimal Area1Count { get; set; }
        public decimal Area2 { get; set; }
        public decimal Area2NewAdd { get; set; }
        public decimal Area2Settle { get; set; }
        public decimal Area2Count { get; set; }
        public virtual U_UserInfo U_UserInfo { get; set; }
    }
}
