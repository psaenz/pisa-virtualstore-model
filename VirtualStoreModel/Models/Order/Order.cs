namespace Pisa.VirtualStore.Models.Order
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;
    using Pisa.VirtualStore.Models.Archived;
    using Pisa.VirtualStore.Models.Calculus;
    using Pisa.VirtualStore.Models.General;
    using Pisa.VirtualStore.Models.Contact;
    using Pisa.VirtualStore.Models.Client;
    using Pisa.VirtualStore.Models.Service;
    using Pisa.VirtualStore.Models.Store;
    using Pisa.VirtualStore.Models.Security;

    public partial class Order : BaseAuditableModel
    {
        public int IdRequestedByUser { get; set; }

        public int IdClientBasket { get; set; }

        public int IdGeneralStatus { get; set; }

        public int IdServiceType { get; set; }

        public int IdSecurityAccountAddress { get; set; }

        public int IdStore { get; set; }

        public double Amount { get; set; }

        public DateTime DateRequested { get; set; }

        public DateTime? DateDelivered { get; set; }

        public bool Scheduled { get; set; }

        public virtual SecurityUser RequestedByUser { get; set; }

        public virtual ClientBasket ClientBasket { get; set; }

        public virtual GeneralStatus GeneralStatus { get; set; }

        public virtual ServiceType ServiceType { get; set; }

        public virtual SecurityAccountAddress SecurityAccountAddress { get; set; }

        public virtual Store Store { get; set; }
    }
}
