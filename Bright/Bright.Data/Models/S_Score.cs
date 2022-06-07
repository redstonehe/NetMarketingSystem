using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class S_Score
    {
        public System.Guid ScoreId { get; set; }
        public System.Guid Fk_UserId { get; set; }
        public Nullable<System.Guid> OrderUserId { get; set; }
        public string OrderCode { get; set; }
        public int Area { get; set; }
        public decimal Amount { get; set; }
        public int PhaseId { get; set; }
        public System.DateTime CreateTime { get; set; }
        public string Remark { get; set; }
        public bool IsOld { get; set; }
        public virtual U_UserInfo U_UserInfo { get; set; }
    }
}
