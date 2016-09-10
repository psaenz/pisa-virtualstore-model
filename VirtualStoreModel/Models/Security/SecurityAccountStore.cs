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

    /// <summary>
    /// Links an <see cref="SecurityAccount"/> with and <see cref="Store"/>
    /// We could have a property in the Store that points to an SecurityAccount...
    /// but I dont want to have security stuff in non-security related classes
    /// </summary>
    public partial class SecurityAccountStore : BaseAuditableModel
    {
        public int IdSecurityAccount { get; set; }

        public int IdStore { get; set; }

        public virtual SecurityAccount SecurityAccount { get; set; }

        public virtual Store Store { get; set; }
    }
}
