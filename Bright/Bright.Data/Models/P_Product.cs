using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class P_Product
    {
        public P_Product()
        {
            this.O_Product = new List<O_Product>();
            this.O_Product1 = new List<O_Product>();
            this.P_Package = new List<P_Package>();
            this.P_Package1 = new List<P_Package>();
            this.P_Price = new List<P_Price>();
            this.P_TeamProduct = new List<P_TeamProduct>();
        }

        public System.Guid ProductId { get; set; }
        public int Fk_CategoryId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public string ProductBarcode { get; set; }
        public double ProductWeight { get; set; }
        public decimal ProductCost { get; set; }
        public string ProductDescription { get; set; }
        public string ProductContent { get; set; }
        public string ProductImg { get; set; }
        public bool IsPackage { get; set; }
        public bool IsSale { get; set; }
        public System.DateTime CreateTime { get; set; }
        public virtual ICollection<O_Product> O_Product { get; set; }
        public virtual ICollection<O_Product> O_Product1 { get; set; }
        public virtual P_Category P_Category { get; set; }
        public virtual ICollection<P_Package> P_Package { get; set; }
        public virtual ICollection<P_Package> P_Package1 { get; set; }
        public virtual ICollection<P_Price> P_Price { get; set; }
        public virtual ICollection<P_TeamProduct> P_TeamProduct { get; set; }
    }
}
