namespace Pisa.VirtualStore.Models.Order
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;
    using Pisa.VirtualStore.Models.General;
    using Pisa.VirtualStore.Models.Security;

    public partial class OrderSchedule : BaseAuditableModel
    {
        public int IdSecurityUser { get; set; }

        public int IdOrder { get; set; }

        public int IdGeneralSchedule { get; set; }

        public int IdGeneralStatus { get; set; }

        public virtual SecurityUser SecurityUser { get; set; }

        public virtual Order Order { get; set; }

        public virtual GeneralSchedule GeneralSchedule { get; set; }

        public virtual GeneralStatus GeneralStatus { get; set; }
    }
}
