using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class P_Package
    {
        public System.Guid PackageId { get; set; }
        public System.Guid Fk_Productd { get; set; }
        public System.Guid ChildProducttId { get; set; }
        public int ProductCount { get; set; }
        public virtual P_Product P_Product { get; set; }
        public virtual P_Product P_Product1 { get; set; }
    }
}
