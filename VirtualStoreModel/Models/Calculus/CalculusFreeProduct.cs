namespace Pisa.VirtualStore.Models.Calculus
{
    using System;
    using System.Collections.Generic;
    using Pisa.VirtualStore.Models.Product;
    using Pisa.VirtualStore.Models.Base;

    public partial class CalculusFreeProduct : BaseModel
    {
        public int CalculusOrderId { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public virtual CalculusOrder CalculusOrder { get; set; }

        public virtual ProductInfo Product { get; set; }
    }
}
