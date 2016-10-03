namespace Pisa.VirtualStore.Models.Service
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;

    public partial class ServiceRule : BaseAuditableModel
    {
        public int ServiceByStoreId { get; set; }

        public int ServiceZoneId { get; set; }

        public double ShoppingAmount { get; set; }

        public double ChargeByService { get; set; }

        public bool ApplyAsPercentage { get; set; }

        public virtual ServiceByStore ServiceByStore { get; set; }

        public virtual ServiceZone ServiceZone { get; set; }
    }
}
