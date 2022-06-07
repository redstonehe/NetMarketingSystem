using System;
using System.Collections.Generic;

namespace Bright.Data.Models
{
    public partial class U_Address
    {
        public System.Guid AddressId { get; set; }
        public System.Guid Fk_UserId { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string Address { get; set; }
        public string Post { get; set; }
        public string Receiver { get; set; }
        public string Phone { get; set; }
        public bool IsDefault { get; set; }
        public virtual U_UserInfo U_UserInfo { get; set; }
    }
}
