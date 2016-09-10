namespace Pisa.VirtualStore.Models.Order
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;

    public partial class OrderScheduleControl : BaseModel
    {
        public DateTime Date { get; set; }

        public int OrdersGenerated { get; set; }
    }
}
