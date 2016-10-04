namespace Pisa.VirtualStore.Models.Store
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;
    using Pisa.VirtualStore.Models.Contact;

    public partial class StoreContact : BaseAuditableModel
    {
        public int ContactId { get; set; }

        public int StoreId { get; set; }

        public virtual Contact Contact { get; set; }

        public virtual StoreInfo Store { get; set; }
    }
}
