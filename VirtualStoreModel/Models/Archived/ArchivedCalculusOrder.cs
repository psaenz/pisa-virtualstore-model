namespace Pisa.VirtualStore.Models.Archived
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Order;
    using Pisa.VirtualStore.Models.Store;
    using Pisa.VirtualStore.Models.Base;

    public partial class ArchivedCalculusOrder : BaseModel
    {
        public int OrderId { get; set; }

        public int StoreId { get; set; }

        public DateTime CalculusDate { get; set; }

        public virtual Store Store { get; set; }

        public virtual Order Order { get; set; }
    }
}
