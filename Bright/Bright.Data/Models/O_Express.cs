using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class O_Express
    {
        public O_Express()
        {
            this.O_Order = new List<O_Order>();
        }

        public int ExpressId { get; set; }
        public string ExpressName { get; set; }
        public string ExpressTel { get; set; }
        public string ExpressUrl { get; set; }
        public string Remark { get; set; }
        public bool IsDefault { get; set; }
        public virtual ICollection<O_Order> O_Order { get; set; }
    }
}
