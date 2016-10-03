namespace Pisa.VirtualStore.Models.Order
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;
    using Pisa.VirtualStore.Models.General;
    using Pisa.VirtualStore.Models.Security;

    public partial class OrderSchedule : BaseAuditableModel
    {
        public int SecurityUserId { get; set; }

        public int OrderId { get; set; }

        public int GeneralScheduleId { get; set; }

        public int GeneralStatusId { get; set; }

        public virtual SecurityUser SecurityUser { get; set; }

        public virtual Order Order { get; set; }

        public virtual GeneralSchedule GeneralSchedule { get; set; }

        public virtual GeneralStatus GeneralStatus { get; set; }
    }
}
