using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class C_BankFilling
    {
        public System.Guid BackId { get; set; }
        public System.Guid Fk_UserId { get; set; }
        public decimal Ammount { get; set; }
        public decimal Ammounted { get; set; }
        public double FillingPercent { get; set; }
        public int Status { get; set; }
        public string Remark { get; set; }
        public virtual U_UserInfo U_UserInfo { get; set; }
    }
}
