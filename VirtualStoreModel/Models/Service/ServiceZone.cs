namespace Pisa.VirtualStore.Models.Service
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Store;
    using Pisa.VirtualStore.Models.Base;

    public partial class ServiceZone : BaseAuditableModel
    {
        public int IdStore { get; set; }

        public string Name { get; set; }

        public virtual Store Store { get; set; }
    }
}
