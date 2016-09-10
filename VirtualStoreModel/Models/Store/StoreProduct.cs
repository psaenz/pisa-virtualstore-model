namespace Pisa.VirtualStore.Models.Store
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Base;
    using Pisa.VirtualStore.Models.Product;

    public partial class StoreProduct : BaseAuditableModel
    {
        public int IdStore { get; set; }

        public int IdProduct { get; set; }

        public string ProductCode { get; set; }

        public double Price { get; set; }

        public virtual Product Product { get; set; }

        public virtual Store Store { get; set; }
    }
}
