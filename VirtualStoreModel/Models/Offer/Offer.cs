namespace Pisa.VirtualStore.Models.Offer
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;
    using Pisa.VirtualStore.Models.Store;
    using Pisa.VirtualStore.Models.General;
    using Pisa.VirtualStore.Models.Archived;
    using Pisa.VirtualStore.Models.Calculus;

    public partial class Offer : BaseAuditableModel
    {
        public int StoreId { get; set; }

        public int GeneralStatusId { get; set; }

        public int GeneralMediaId { get; set; }

        public int GeneralScheduleId { get; set; }

        public string Name { get; set; }

        public int MaximumPerOrder { get; set; }

        public virtual Store Store { get; set; }

        public virtual GeneralStatus GeneralStatus { get; set; }

        public virtual GeneralMedia GeneralMedia { get; set; }

        public virtual GeneralSchedule GeneralSchedule { get; set; }
    }
}
