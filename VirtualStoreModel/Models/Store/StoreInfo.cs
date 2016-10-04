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

    public partial class StoreInfo : BaseAuditableModel
    {
        public string Name { get; set; }

        public Nullable<int> StoreParentId { get; set; }

        public int GeneralStatusId { get; set; }

        public int? GeneralMediaLogoId { get; set; }

        public virtual StoreInfo StoreParent { get; set; }

        public virtual GeneralStatus GeneralStatus { get; set; }

        public virtual GeneralMedia GeneralMediaLogo { get; set; }
    }
}
