using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class U_Rank
    {
        public U_Rank()
        {
            this.U_RankHistory = new List<U_RankHistory>();
            this.U_RankSend = new List<U_RankSend>();
        }

        public int RankId { get; set; }
        public string RankName { get; set; }
        public decimal RankMoney { get; set; }
        public decimal RankPv { get; set; }
        public int Fk_TitleId { get; set; }
        public double RecommendPercent { get; set; }
        public bool IsCreatStation { get; set; }
        public int StationRankId { get; set; }
        public virtual U_AwardTitle U_AwardTitle { get; set; }
        public virtual ICollection<U_RankHistory> U_RankHistory { get; set; }
        public virtual ICollection<U_RankSend> U_RankSend { get; set; }
    }
}
