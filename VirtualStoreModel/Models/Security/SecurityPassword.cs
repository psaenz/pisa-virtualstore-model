namespace Pisa.VirtualStore.Models.Security
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;
    public partial class SecurityPassword : BaseAuditableModel
    {
        public int SecurityUserId { get; set; }

        public int Sequence { get; set; }

        public string Password { get; set; }

        public virtual SecurityUser SecurityUser { get; set; }
    }
}
