using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class U_Bank
    {
        public System.Guid BankId { get; set; }
        public System.Guid Fk_UserId { get; set; }
        public string BankName { get; set; }
        public string BankCode { get; set; }
        public string BankProvince { get; set; }
        public string BankCity { get; set; }
        public string BankArea { get; set; }
        public string BankAddress { get; set; }
        public bool IsDefault { get; set; }
        public virtual U_UserInfo U_UserInfo { get; set; }
    }
}
