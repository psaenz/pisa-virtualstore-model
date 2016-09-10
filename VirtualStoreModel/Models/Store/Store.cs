namespace Pisa.VirtualStore.Models.Store
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;
    using Pisa.VirtualStore.Models.Archived;
    using Pisa.VirtualStore.Models.Calculus;
    using Pisa.VirtualStore.Models.Service;
    using Pisa.VirtualStore.Models.Order;
    using Pisa.VirtualStore.Models.General;

    public partial class Store : BaseAuditableModel
    {
        public string Name { get; set; }

        public int IdStoreParent { get; set; }

        public int IdGeneralStatus { get; set; }

        public int IdGeneralMediaLogo { get; set; }

        public virtual Store StoreParent { get; set; }

        public virtual GeneralStatus GeneralStatus { get; set; }

        public virtual GeneralMedia GeneralMediaLogo { get; set; }
        
    }
}
