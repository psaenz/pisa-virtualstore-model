namespace Pisa.VirtualStore.Models.Calculus
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Store;
    using Pisa.VirtualStore.Models.Order;
    using Pisa.VirtualStore.Models.Base;

    public partial class CalculusOrder : BaseModel
    {
        public int OrderId { get; set; }

        public int StoreId { get; set; }

        public DateTime CalculusDate { get; set; }

        public virtual StoreInfo Store { get; set; }

        public virtual OrderInfo Order { get; set; }
    }
}
