using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class P_TeamProduct
    {
        public System.Guid TpId { get; set; }
        public int Fk_TeamId { get; set; }
        public System.Guid Fk_ProductId { get; set; }
        public virtual P_Product P_Product { get; set; }
        public virtual U_Team U_Team { get; set; }
    }
}
