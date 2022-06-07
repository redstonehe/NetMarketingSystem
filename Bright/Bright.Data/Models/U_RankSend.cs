using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class U_RankSend
    {
        public int SendId { get; set; }
        public int Fk_RankId { get; set; }
        public int Fk_AccountId { get; set; }
        public decimal Amount { get; set; }
        public virtual U_Rank U_Rank { get; set; }
    }
}
