namespace Pisa.VirtualStore.Models.Service
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;
    using Pisa.VirtualStore.Models.Archived;
    using Pisa.VirtualStore.Models.Client;
    using Pisa.VirtualStore.Models.Calculus;
    using Pisa.VirtualStore.Models.Contact;
    using Pisa.VirtualStore.Models.General;
    using Pisa.VirtualStore.Models.Offer;
    using Pisa.VirtualStore.Models.Order;
    using Pisa.VirtualStore.Models.Product;
    using Pisa.VirtualStore.Models.Security;
    using Pisa.VirtualStore.Models.Service;
    using Pisa.VirtualStore.Models.Store;

    public partial class ServiceByStore : BaseAuditableModel
    {
        public int StoreId { get; set; }

        public int ServiceTypeId { get; set; }

        public int GeneralStatusId { get; set; }

        public virtual Store Store { get; set; }

        public virtual ServiceType ServiceType { get; set; }

        public virtual GeneralStatus GeneralStatus { get; set; }
    }
}
