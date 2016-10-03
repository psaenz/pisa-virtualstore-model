namespace Pisa.VirtualStore.Models.Contact
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Order;
    using Pisa.VirtualStore.Models.Store;
    using Pisa.VirtualStore.Models.General;
    using Pisa.VirtualStore.Models.Base;

    public partial class ContactRegion : BaseModel
    {
        public string Name { get; set; }

        public int? ContactRegionParentId { get; set; }

        public int GeneralStatusId { get; set; }

        public virtual ContactRegion ContactRegionParent { get; set; }

        public virtual GeneralStatus GeneralStatus { get; set; }
    }
}
