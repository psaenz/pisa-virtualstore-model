namespace Pisa.VirtualStore.Models.Store
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;
    using Pisa.VirtualStore.Models.Contact;

    public partial class StoreAddress : BaseAuditableModel
    {
        public int IdContactAddress { get; set; }

        public int IdStore { get; set; }

        public virtual ContactAddress ContactAddress { get; set; }

        public virtual Store Store { get; set; }
    }
}
