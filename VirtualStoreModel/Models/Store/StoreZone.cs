using Pisa.VirtualStore.Models.General;

namespace Pisa.VirtualStore.Models.Store
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;
    using Pisa.VirtualStore.Models.Contact;
    using Pisa.VirtualStore.Models.Service;

    public partial class StoreZone : BaseAuditableModel
    {
        public int? IdContactRegion { get; set; }

        public int IdServiceZone { get; set; }

        public virtual ContactRegion ContactRegion { get; set; }

        public virtual ServiceZone ServiceZone { get; set; }
    }
}
