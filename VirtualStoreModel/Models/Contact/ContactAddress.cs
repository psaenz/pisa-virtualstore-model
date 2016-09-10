namespace Pisa.VirtualStore.Models.Contact
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Security;
    using Pisa.VirtualStore.Models.Store;
    using Pisa.VirtualStore.Models.Base;
    using Pisa.VirtualStore.Models.Base;

    public partial class ContactAddress : BaseAuditableModel
    {
        public int IdContactRegion { get; set; }

        public string Details { get; set; }

        public virtual ContactRegion ContactRegion { get; set; }
    }
}
