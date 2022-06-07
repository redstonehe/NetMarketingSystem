using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class P_Price
    {
        public System.Guid PriceId { get; set; }
        public int Fk_TypeId { get; set; }
        public System.Guid Fk_ProductId { get; set; }
        public decimal MarketPrice { get; set; }
        public decimal MallPrice { get; set; }
        public decimal ProductPv { get; set; }
        public bool IsPromotion { get; set; }
        public decimal PromotionPrice { get; set; }
        public decimal PromotionPv { get; set; }
        public virtual O_Type O_Type { get; set; }
        public virtual P_Product P_Product { get; set; }
    }
}
