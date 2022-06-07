using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class O_Type
    {
        public O_Type()
        {
            this.P_Price = new List<P_Price>();
        }

        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public string OrderPrefix { get; set; }
        public bool IsScore { get; set; }
        public bool IsRecommendAward { get; set; }
        public bool IsStationAward { get; set; }
        public bool IsDifferentialAward { get; set; }
        public virtual ICollection<P_Price> P_Price { get; set; }
    }
}
