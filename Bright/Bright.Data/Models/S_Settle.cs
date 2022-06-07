using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class S_Settle
    {
        public System.Guid SettleId { get; set; }
        public System.Guid Fk_UserId { get; set; }
        public int PhaseId { get; set; }
        public int Area { get; set; }
        public decimal Amount { get; set; }
        public decimal LimitAmount { get; set; }
        public decimal LeftAmount { get; set; }
    }
}
