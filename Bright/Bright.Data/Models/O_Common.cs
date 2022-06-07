using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class O_Common
    {
        public O_Common()
        {
            this.O_Product = new List<O_Product>();
        }

        public System.Guid OrderId { get; set; }
        public string OrderCode { get; set; }
        public System.Guid Fk_UserId { get; set; }
        public int Fk_TypeId { get; set; }
        public decimal OrderMoney { get; set; }
        public decimal OrderPv { get; set; }
        public System.DateTime CreateTime { get; set; }
        public Nullable<System.DateTime> PayTime { get; set; }
        public Nullable<System.DateTime> BackTime { get; set; }
        public int Status { get; set; }
        public Nullable<System.Guid> OrderUserId { get; set; }
        public Nullable<System.Guid> ReceiveUserId { get; set; }
        public Nullable<System.Guid> PayUserId { get; set; }
        public string Remark { get; set; }
        public virtual O_Order O_Order { get; set; }
        public virtual ICollection<O_Product> O_Product { get; set; }
    }
}
