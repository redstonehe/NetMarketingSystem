using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class C_AccountType
    {
        public C_AccountType()
        {
            this.C_Account = new List<C_Account>();
            this.C_Cash = new List<C_Cash>();
            this.C_CashFlow = new List<C_CashFlow>();
            this.C_Recharge = new List<C_Recharge>();
            this.C_Transfer = new List<C_Transfer>();
            this.C_Transfer1 = new List<C_Transfer>();
        }

        public int AccountId { get; set; }
        public string AccountName { get; set; }
        public bool IsInterTransfer { get; set; }
        public string InterAccountIds { get; set; }
        public bool IsOuterTransfer { get; set; }
        public string OuterAccountIds { get; set; }
        public bool IsAble { get; set; }
        public decimal TransferMin { get; set; }
        public decimal TransferMultiple { get; set; }
        public bool IsRecharge { get; set; }
        public bool IsCash { get; set; }
        public double CashPercent { get; set; }
        public int CashDayCount { get; set; }
        public double CashCost { get; set; }
        public bool IsBackFilling { get; set; }
        public virtual ICollection<C_Account> C_Account { get; set; }
        public virtual ICollection<C_Cash> C_Cash { get; set; }
        public virtual ICollection<C_CashFlow> C_CashFlow { get; set; }
        public virtual ICollection<C_Recharge> C_Recharge { get; set; }
        public virtual ICollection<C_Transfer> C_Transfer { get; set; }
        public virtual ICollection<C_Transfer> C_Transfer1 { get; set; }
    }
}
