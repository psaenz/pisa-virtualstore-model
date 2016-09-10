namespace Pisa.VirtualStore.Models.Store
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;
    using Pisa.VirtualStore.Models.Contact;

    public partial class StoreContact : BaseAuditableModel
    {
        public int IdContact { get; set; }

        public int IdStore { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual Store Store { get; set; }
    }
}
