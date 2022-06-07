using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class O_Order
    {
        public System.Guid OrderId { get; set; }
        public string OrderCode { get; set; }
        public int Fk_ExpressId { get; set; }
        public string ReceiveUserName { get; set; }
        public string Tel { get; set; }
        public string Phone { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string Address { get; set; }
        public decimal ExpressMoney { get; set; }
        public int ExpressStatus { get; set; }
        public Nullable<System.DateTime> ReceiveTime { get; set; }
        public bool IsInvoice { get; set; }
        public string InvoiceType { get; set; }
        public string InvoiceTitle { get; set; }
        public string InvoiceContent { get; set; }
        public string InvoiceCompany { get; set; }
        public virtual O_Common O_Common { get; set; }
        public virtual O_Express O_Express { get; set; }
    }
}
