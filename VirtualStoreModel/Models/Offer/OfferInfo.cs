namespace Pisa.VirtualStore.Models.Offer
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;
    using Pisa.VirtualStore.Models.Store;
    using Pisa.VirtualStore.Models.General;
    using Pisa.VirtualStore.Models.Archived;
    using Pisa.VirtualStore.Models.Calculus;

    public partial class OfferInfo : BaseAuditableModel
    {
        public int StoreId { get; set; }

        public int GeneralStatusId { get; set; }

        public Nullable<int> GeneralMediaId { get; set; }

        public Nullable<int> GeneralScheduleId { get; set; }

        public string Name { get; set; }

        public int MaximumPerOrder { get; set; }

        public virtual StoreInfo Store { get; set; }

        public virtual GeneralStatus GeneralStatus { get; set; }

        public virtual GeneralMedia GeneralMedia { get; set; }

        public virtual GeneralSchedule GeneralSchedule { get; set; }
    }
}
