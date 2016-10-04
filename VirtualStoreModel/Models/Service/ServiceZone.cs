namespace Pisa.VirtualStore.Models.Service
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Store;
    using Pisa.VirtualStore.Models.Base;

    public partial class ServiceZone : BaseAuditableModel
    {
        public int StoreId { get; set; }

        public string Name { get; set; }

        public virtual StoreInfo Store { get; set; }
    }
}
