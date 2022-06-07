using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class U_ManagerRelation
    {
        public System.Guid RelationId { get; set; }
        public System.Guid Fk_UserId { get; set; }
        public System.Guid Fk_ManagerUserId { get; set; }
        public int Area { get; set; }
        public int Depth { get; set; }
        public virtual U_UserInfo U_UserInfo { get; set; }
        public virtual U_UserInfo U_UserInfo1 { get; set; }
    }
}
