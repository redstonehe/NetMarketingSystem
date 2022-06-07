using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class U_RankHistory
    {
        public System.Guid HistoryId { get; set; }
        public System.Guid Fk_UserId { get; set; }
        public int Fk_RankId { get; set; }
        public System.DateTime ChangeTime { get; set; }
        public string Remark { get; set; }
        public virtual U_Rank U_Rank { get; set; }
        public virtual U_UserInfo U_UserInfo { get; set; }
    }
}
