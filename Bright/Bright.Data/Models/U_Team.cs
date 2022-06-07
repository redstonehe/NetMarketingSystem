using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class U_Team
    {
        public U_Team()
        {
            this.P_TeamProduct = new List<P_TeamProduct>();
        }

        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public virtual ICollection<P_TeamProduct> P_TeamProduct { get; set; }
    }
}
