using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class C_Currency
    {
        public int CurrencyId { get; set; }
        public string CurrencyName { get; set; }
        public string Sign { get; set; }
        public double Rate { get; set; }
        public bool IsCosts { get; set; }
    }
}
