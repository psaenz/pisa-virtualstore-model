namespace Pisa.VirtualStore.Models.Store
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;
    using Pisa.VirtualStore.Models.Product;

    public partial class StoreProduct : BaseAuditableModel
    {
        public int StoreId { get; set; }

        public int ProductId { get; set; }

        public string ProductCode { get; set; }

        public double Price { get; set; }

        public virtual ProductInfo Product { get; set; }

        public virtual StoreInfo Store { get; set; }
    }
}
