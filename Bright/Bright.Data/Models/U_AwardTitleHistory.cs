using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class U_AwardTitleHistory
    {
        public System.Guid HistoryId { get; set; }
        public System.Guid Fk_UserId { get; set; }
        public int Fk_TitleId { get; set; }
        public System.DateTime ChangeTime { get; set; }
        public string Remark { get; set; }
        public virtual U_AwardTitle U_AwardTitle { get; set; }
        public virtual U_UserInfo U_UserInfo { get; set; }
    }
}
