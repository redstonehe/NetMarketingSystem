using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class P_Category
    {
        public P_Category()
        {
            this.P_Product = new List<P_Product>();
        }

        public int CategoryId { get; set; }
        public Nullable<int> CategoryParentId { get; set; }
        public string CategoryName { get; set; }
        public int CategorySeq { get; set; }
        public bool IsShow { get; set; }
        public virtual ICollection<P_Product> P_Product { get; set; }
    }
}
