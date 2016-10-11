namespace Pisa.VirtualStore.Models.Security
{
    using System;
    using System.Collections.Generic;
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
    using Pisa.VirtualStore.Models.Base;

    public partial class SecurityAccountContact : BaseAuditableModel
    {
        public int ContactId { get; set; }

        public int SecurityAccountId { get; set; }

        public virtual ContactInfo Contact { get; set; }

        public virtual SecurityAccount SecurityAccount { get; set; }
    }
}
