using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class O_Product
    {
        public O_Product()
        {
            this.O_Product1 = new List<O_Product>();
        }

        public System.Guid OrderProductId { get; set; }
        public System.Guid Fk_OrderId { get; set; }
        public System.Guid Fk_ProductId { get; set; }
        public Nullable<System.Guid> Fk_ParentId { get; set; }
        public int ProductCount { get; set; }
        public decimal Price { get; set; }
        public decimal Pv { get; set; }
        public bool IsPackage { get; set; }
        public string Remark { get; set; }
        public virtual O_Common O_Common { get; set; }
        public virtual ICollection<O_Product> O_Product1 { get; set; }
        public virtual O_Product O_Product2 { get; set; }
        public virtual P_Product P_Product { get; set; }
        public virtual P_Product P_Product1 { get; set; }
    }
}
