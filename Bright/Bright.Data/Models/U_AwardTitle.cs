using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class U_AwardTitle
    {
        public U_AwardTitle()
        {
            this.U_AwardTitleHistory = new List<U_AwardTitleHistory>();
            this.U_Rank = new List<U_Rank>();
        }

        public int TitleId { get; set; }
        public string TitleName { get; set; }
        public int AreaCount { get; set; }
        public decimal TotalScore { get; set; }
        public decimal SmallScore { get; set; }
        public int ChildRankId { get; set; }
        public int ChildRankCount { get; set; }
        public int RankMod { get; set; }
        public int ChildTitleId { get; set; }
        public int ChildTitleCount { get; set; }
        public int TitleMod { get; set; }
        public virtual ICollection<U_AwardTitleHistory> U_AwardTitleHistory { get; set; }
        public virtual ICollection<U_Rank> U_Rank { get; set; }
    }
}
