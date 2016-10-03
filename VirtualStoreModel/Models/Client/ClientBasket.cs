namespace Pisa.VirtualStore.Models.Client
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;
    using Pisa.VirtualStore.Models.Security;

    public partial class ClientBasket : BaseAuditableModel
    {
        public int SecurityUserId { get; set; }

        public int Sequence { get; set; }

        public string Name { get; set; }

        public virtual SecurityUser SecurityUser { get; set; }
    }
}
